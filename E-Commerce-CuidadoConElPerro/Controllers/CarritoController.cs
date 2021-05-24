using E_Commerce_CuidadoConElPerro.Models;
using E_Commerce_CuidadoConElPerro.Sesiones;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_CuidadoConElPerro.Controllers
{
    public class CarritoController : Controller
    {
        private readonly CuidadoConElPerroContext db;
        private readonly IWebHostEnvironment env;
        public CarritoController(CuidadoConElPerroContext db, IWebHostEnvironment env)
        {
            this.db = db;
            this.env = env;
        }

        [Authorize]
        public IActionResult AgregarCarrito(int? id)
        {
            HttpContext.Session.SetString("Nombre", HttpContext.User.Identity.Name);
            ViewBag.Nombre = HttpContext.Session.GetString("Nombre");
            if (id == null)
                return NotFound();
            Prendum prenda = db.Prenda.Find(id);
            if (prenda == null)
                return NotFound();
            return View(prenda);
        }

        [Authorize]
        [HttpPost]
        public IActionResult AgregarCarrito(int id, int? cantidad)
        {
            if (cantidad == null || id == null)
                ModelState.AddModelError("", "Datos no validos");
            Prendum p = db.Prenda.Find(id);
            if (p.Cantidad < cantidad)
                ModelState.AddModelError("", "No se puede agregar más productos de los que hay");
            if (ModelState.IsValid)
            {
                Carrito carrito = new Carrito { Cantidad = (int)cantidad, Prenda = p };
                List<Carrito> ListaCarrito;
                if (SessionHelper.GetProductoFromJson<List<Carrito>>(HttpContext.Session, "Carrito") == null)
                {
                    ListaCarrito = new List<Carrito>();
                }
                else
                {
                    ListaCarrito = SessionHelper.GetProductoFromJson<List<Carrito>>(HttpContext.Session, "Carrito");
                }
                var lista = ListaCarrito.Find(x => x.Prenda.IdPrenda == id);
                if (lista == null)
                {
                    ListaCarrito.Add(carrito);
                    SessionHelper.SetProductoAsJson(HttpContext.Session, "Carrito", ListaCarrito);
                    TempData["Carrito"] = "Se ha agregado correctamente";
                    return RedirectToAction("verPrendas", "Cliente");
                }
                else
                {
                    if (lista.Prenda.IdPrenda == id)
                    {
                        lista.Cantidad = (int)(lista.Cantidad + cantidad);
                        SessionHelper.SetProductoAsJson(HttpContext.Session, "Carrito", ListaCarrito);
                        return RedirectToAction("verPrendas", "Cliente");
                    }
                }
            }
            return View();
        }

        public IActionResult EliminarCarrito()
        {
            HttpContext.Session.Remove("Carrito");
            TempData["Pagado"] = "Carrito pagado";
            return RedirectToAction("verPrendas", "Cliente");
        }

        [Authorize]
        public IActionResult MostrarCarrito()
        {
            ViewBag.Nombre = HttpContext.Session.GetString("Nombre");
            List<Carrito> ListaCarrito;
            if (SessionHelper.GetProductoFromJson<List<Carrito>>(HttpContext.Session, "Carrito") == null )
            {
                ListaCarrito = new List<Carrito>();
            }
            else
            {
                ListaCarrito = SessionHelper.GetProductoFromJson<List<Carrito>>(HttpContext.Session, "Carrito");
            }
            ViewBag.MetodosDePago = new SelectList(db.MetodoPagos, "IdMetodoPago", "Nombre");
            return View(ListaCarrito);
        }

        [Authorize]
        public IActionResult ObtenerFoto(int id)
        {
            try
            {
                var prenda = db.Prenda.Find(id);
                return File(prenda.Imagen, "image/jpeg");
            }
            catch (Exception)
            {
                var path = Path.Combine(env.WebRootPath, "img", "not-found.png");
                return PhysicalFile(path, "image/png");
            }
        }

        [Authorize]
        public IActionResult Eliminar(int? id)
        {
            List<Carrito> ListaCarrito;
            ListaCarrito = SessionHelper.GetProductoFromJson<List<Carrito>>(HttpContext.Session, "Carrito");
            var lista = ListaCarrito.Find(x => x.Prenda.IdPrenda == id);
            ListaCarrito.Remove(lista);
            SessionHelper.SetProductoAsJson(HttpContext.Session, "Carrito", ListaCarrito); 
            TempData["Eliminado"] = "Producto eliminado";
            return RedirectToAction("verPrendas", "Cliente");
        }



    }
}
