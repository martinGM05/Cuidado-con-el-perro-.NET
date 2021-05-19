using E_Commerce_CuidadoConElPerro.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Hosting;
using E_Commerce_CuidadoConElPerro.Sesiones;
using Microsoft.AspNetCore.Authorization;

namespace E_Commerce_CuidadoConElPerro.Controllers
{
    public class EmpleadosController : Controller
    {
        private readonly CuidadoConElPerroContext db;
        private readonly IWebHostEnvironment env;

        public EmpleadosController(CuidadoConElPerroContext db, IWebHostEnvironment env)
        {
            this.db = db;
            this.env = env;
        }

        [Authorize]
        public IActionResult Inicio()
        {
            return View();
        }

        [Authorize]
        public IActionResult AgregarPrenda()
        {
            
            ViewBag.Proovedores = new SelectList(db.Proovedors, "IdProovedor", "NombreProovedor");
            ViewBag.Tallas = db.Tallas.ToList();
            ViewBag.Departamentos = new SelectList(db.Departamentos, "IdDepartamento", "NombreDepartamento");
            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult AgregarPrenda(Prendum prenda, IFormFile foto)
        {
            byte[] imagenPrenda = null;
            using (MemoryStream ms = new MemoryStream())
            {
                foto.CopyTo(ms);
                imagenPrenda = ms.ToArray();
            }
            prenda.Imagen = imagenPrenda;
            db.Prenda.Add(prenda);
            db.SaveChanges();
            TempData["Message"] = prenda.NombrePrenda+" fue registrado";
            return View("Inicio");
        }

        [Authorize]
        public IActionResult AgregarDepartamento()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult AgregarDepartamento(Departamento departamento)
        {
            db.Departamentos.Add(departamento);
            db.SaveChanges();
            TempData["Message"] = departamento.NombreDepartamento + " fue registrad@";
            return RedirectToAction("Inicio");
        }

        [Authorize]
        public IActionResult AgregarProovedor()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult AgregarProovedor(Proovedor proovedor)
        {
            db.Proovedors.Add(proovedor);
            db.SaveChanges();
            TempData["Message"] = proovedor.NombreProovedor+ " fue registrad@";
            return RedirectToAction("Inicio");
        }

        [Authorize]
        public IActionResult VerDepartamento()
        {
            return View(db.Departamentos.ToList());
        }

        [Authorize]
        public IActionResult VerProovedor()
        {
            return View(db.Proovedors.ToList());
        }

        [Authorize]
        public IActionResult VerPrenda()
        {
            db.Tallas.ToList();
            db.Departamentos.ToList();
            db.Proovedors.ToList();
            return View(db.Prenda.ToList());
        }

        [Authorize]
        public IActionResult ActualizarDepartamento(int ? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Departamento departamento = db.Departamentos.Find(id);
            if (departamento == null)
                return NotFound();
            return View(departamento);
        }

        [Authorize]
        [HttpPost]
        public IActionResult ActualizarDepartamento(Departamento departamento)
        {
            db.Entry(departamento).State = EntityState.Modified;
            db.SaveChanges();
            TempData["Actualizar"] = departamento.NombreDepartamento + " fue actualizad@";
            return RedirectToAction("VerDepartamento");
        }

        [Authorize]
        public IActionResult ActualizarProovedor(int ? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Proovedor proovedor= db.Proovedors.Find(id);
            if (proovedor == null)
                return NotFound();
            return View(proovedor);
        }

        [Authorize]
        [HttpPost]
        public IActionResult ActualizarProovedor(Proovedor proovedor)
        {
            db.Entry(proovedor).State = EntityState.Modified;
            db.SaveChanges();
            TempData["Actualizar"] = proovedor.NombreProovedor + " fue actualizad@";
            return RedirectToAction("VerProovedor");
        }

        [Authorize]
        public IActionResult ActualizarPrenda(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Prendum prenda = db.Prenda.Find(id);
            if (prenda == null)
                return NotFound();
            Sesiones.SessionHelper.SetProductoAsJson(HttpContext.Session, "foto", prenda.Imagen);
            ViewBag.Proovedores = new SelectList(db.Proovedors, "IdProovedor", "NombreProovedor");
            ViewBag.Tallas = db.Tallas.ToList();
            ViewBag.Departamentos = new SelectList(db.Departamentos, "IdDepartamento", "NombreDepartamento");
            return View(prenda);
        }

        [Authorize]
        [HttpPost]
        public IActionResult ActualizarPrenda(Prendum prenda, IFormFile foto)
        {
            if (ModelState.IsValid)
            {
                if (foto == null)
                {
                    prenda.Imagen = SessionHelper.GetProductoFromJson<byte[]>(HttpContext.Session, "foto");
                }
                else
                {
                    byte[] imagenPrenda = null;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        foto.CopyTo(ms);
                        imagenPrenda = ms.ToArray();
                    }
                    prenda.Imagen = imagenPrenda;
                }
                db.Entry(prenda).State = EntityState.Modified;
                db.SaveChanges();
                TempData["Actualizar"] = prenda.NombrePrenda + " fue actualizad@";
                return RedirectToAction("VerPrenda");
            }
            return View(prenda);
        }

        [Authorize]
        public IActionResult EliminarDepartamento(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Departamento departamento = db.Departamentos.Find(id);
            if (departamento == null)
                return NotFound();
            return View(departamento);
        }

        [Authorize]
        [HttpPost]
        public IActionResult EliminarDepartamento(int id)
        {
            Departamento departamento = db.Departamentos.Find(id);
            db.Departamentos.Remove(departamento);
            db.SaveChanges();
            TempData["Eliminado"] = departamento.NombreDepartamento + " fue eliminad@";
            return RedirectToAction("VerDepartamento");
        }

        [Authorize]
        public IActionResult EliminarProovedor(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Proovedor proovedor= db.Proovedors.Find(id);
            if (proovedor == null)
                return NotFound();
            return View(proovedor);
        }

        [Authorize]
        [HttpPost]
        public IActionResult EliminarProovedor(int id)
        {
            Proovedor proovedor = db.Proovedors.Find(id);
            db.Proovedors.Remove(proovedor);
            db.SaveChanges();
            TempData["Eliminado"] = proovedor.NombreProovedor+ " fue eliminad@";
            return RedirectToAction("VerProovedor");
        }

        [Authorize]
        public IActionResult EliminarPrenda(int? id)
        {
            Prendum prenda = db.Prenda.Find(id);
            db.Prenda.Remove(prenda);
            db.SaveChanges();
            TempData["Eliminado"] = prenda.NombrePrenda + " fue eliminad@";
            return RedirectToAction("VerPrenda");
        }

        [Authorize]
        public IActionResult AgregarEmpleado()
        {
            ViewBag.Rol = new SelectList(db.Rols, "IdRol", "Usuario");
            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult AgregarEmpleado(Empleado empleado, IFormFile foto)
        {
            byte[] imagenEmpleado = null;
            using (MemoryStream ms = new MemoryStream())
            {
                foto.CopyTo(ms);
                imagenEmpleado = ms.ToArray();
            }
            empleado.Imagen = imagenEmpleado;
            db.Empleados.Add(empleado);
            db.SaveChanges();
            TempData["Message"] = empleado.NombreEmpleado + " fue registrad@";
            return RedirectToAction("Inicio");
        }

        [Authorize]
        public IActionResult VerEmpleado()
        {
            db.Rols.ToList();
            return View(db.Empleados.ToList());
        }

        [Authorize]
        public IActionResult ActualizarEmpleado(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Empleado empleado = db.Empleados.Find(id);
            if (empleado == null)
                return NotFound();
            Sesiones.SessionHelper.SetProductoAsJson(HttpContext.Session, "foto", empleado.Imagen);
            ViewBag.Rol = new SelectList(db.Rols, "IdRol", "Usuario");
            return View(empleado);
        }

        [Authorize]
        [HttpPost]
        public IActionResult ActualizarEmpleado(Empleado empleado, IFormFile foto)
        {
            if (ModelState.IsValid)
            {
                if (foto == null)
                {
                    empleado.Imagen = SessionHelper.GetProductoFromJson<byte[]>(HttpContext.Session, "foto");
                }
                else
                {
                    byte[] imagenEmpleado = null;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        foto.CopyTo(ms);
                        imagenEmpleado = ms.ToArray();
                    }
                    empleado.Imagen = imagenEmpleado;
                }
                db.Entry(empleado).State = EntityState.Modified;
                db.SaveChanges();
                TempData["Actualizar"] = empleado.NombreEmpleado + " fue actualizad@";
                return RedirectToAction("VerEmpleado");
            }
            return View(empleado);       
        }

        [Authorize]
        public IActionResult EliminarEmpleado(int? id)
        {
            Empleado empleado = db.Empleados.Find(id);
            db.Empleados.Remove(empleado);
            db.SaveChanges();
            TempData["Eliminado"] = empleado.NombreEmpleado+ " fue eliminad@";
            return RedirectToAction("VerEmpleado");
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
        public IActionResult ObtenerFotoEmpleado(int id)
        {
            try
            {
                var empleado = db.Empleados.Find(id);
                return File(empleado.Imagen, "image/jpeg");
            }
            catch (Exception)
            {
                var path = Path.Combine(env.WebRootPath, "img", "not-found.png");
                return PhysicalFile(path, "image/png");
            }
        }
    }
}
