using E_Commerce_CuidadoConElPerro.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace E_Commerce_CuidadoConElPerro.Controllers
{
    public class ClienteController : Controller
    {
        private readonly CuidadoConElPerroContext db;
        private readonly IWebHostEnvironment env;

        public ClienteController(CuidadoConElPerroContext db, IWebHostEnvironment env)
        {
            this.db = db;
            this.env = env;
        }

        [Authorize]
        public IActionResult Tienda()
        {
            HttpContext.Session.SetString("Nombre", HttpContext.User.Identity.Name);
            ViewBag.Nombre = HttpContext.Session.GetString("Nombre");
            ViewBag.queryTop = db.Prenda.Take(5).ToList();
            ViewBag.Prendas = db.Prenda.ToList();
            return View(db.Departamentos.ToList());
        }

        [Authorize]
        public IActionResult ObtenerFoto(int id)
        {
            try
            {
                var departamento = db.Departamentos.Find(id);
                return File(departamento.Imagen, "image/jpeg");
            }
            catch (Exception)
            {
                var path = Path.Combine(env.WebRootPath, "img", "not-found.png");
                return PhysicalFile(path, "image/png");
            }
        }

        [Authorize]
        public IActionResult ObtenerFotoPrenda(int id)
        {
            try
            {
                var imagenPrenda = db.Prenda.Find(id);
                return File(imagenPrenda.Imagen, "image/jpeg");
            }
            catch (Exception)
            {
                var path = Path.Combine(env.WebRootPath, "img", "not-found.png");
                return PhysicalFile(path, "image/png");
            }
        }

        [Authorize]
        public IActionResult verPrendas(string genero)
        {
            ViewBag.Nombre = HttpContext.Session.GetString("Nombre");
            db.Tallas.ToList();
            db.Proovedors.ToList();
            var consultaDepartamentos = new SelectList(db.Departamentos, "IdDepartamento", "NombreDepartamento");
            List<Prendum> consultaPrenda;
            //idDepartamento = 2;
            //ViewBag.query = db.Prenda.Where(x => x.IdDepartamento == idDepartamento).ToList();
            //ViewBag.prendaSuma = db.Prenda.Where(x => x.IdDepartamento == idDepartamento).Select(x => x.Precio).Sum();

            if (genero == null)
            {
                consultaPrenda = db.Prenda.ToList();
            }
            else
            {
                consultaPrenda = db.Prenda.Where(x => x.Genero == genero).ToList();
            }
            ViewBag.Departamentos = consultaDepartamentos;
            ViewBag.Prenda = consultaPrenda;
            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult verPrendas(int? idDepartamento, string genero)
        {
            db.Tallas.ToList();
            db.Proovedors.ToList();
            var consultaDepartamentos = new SelectList(db.Departamentos, "IdDepartamento", "NombreDepartamento");
            List<Prendum> consultaPrenda;
            if (genero != "Todos")
            {
                if (idDepartamento == null)
                {
                    consultaPrenda = db.Prenda.Where(x => x.Genero == genero).ToList();
                }
                else if (idDepartamento == 0)
                {
                    consultaPrenda = db.Prenda.Where(x => x.Genero == genero).ToList();
                }
                else
                {
                    consultaPrenda = db.Prenda.Where(x => (x.IdDepartamento == idDepartamento) && (x.Genero == genero)).ToList();
                }
            }
            else
            {
                if (idDepartamento == 0)
                {
                    consultaPrenda = db.Prenda.ToList();
                }
                else
                {
                    consultaPrenda = db.Prenda.Where(x => x.IdDepartamento == idDepartamento).ToList();
                }
            }
            ViewBag.Departamentos = consultaDepartamentos;
            ViewBag.Prenda = consultaPrenda;
            return View();
        }

    }
}
