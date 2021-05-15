using E_Commerce_CuidadoConElPerro.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_CuidadoConElPerro.Controllers
{
    public class EmpleadosController : Controller
    {
        private readonly CuidadoConElPerroContext db;

        public EmpleadosController(CuidadoConElPerroContext db)
        {
            this.db = db;
        }

        public IActionResult Inicio()
        {
            return View();
        }

        public IActionResult AgregarPrenda()
        {
            ViewBag.Proovedores = db.Proovedors.ToList();
            ViewBag.Tallas = db.Tallas.ToList();
            ViewBag.Departamentos = db.Departamentos.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult AgregarPrenda(Prendum prenda)
        {
            db.Prenda.Add(prenda);
            db.SaveChanges();
            TempData["Message"] = prenda.NombrePrenda+" fue registrado";
            return View("Inicio");
        }

        public IActionResult AgregarDepartamento()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AgregarDepartamento(Departamento departamento)
        {
            db.Departamentos.Add(departamento);
            db.SaveChanges();
            TempData["Message"] = departamento.NombreDepartamento + " fue registrad@";
            return RedirectToAction("Inicio");
        }

        public IActionResult AgregarProovedor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AgregarProovedor(Proovedor proovedor)
        {
            db.Proovedors.Add(proovedor);
            db.SaveChanges();
            TempData["Message"] = proovedor.NombreProovedor+ " fue registrad@";
            return RedirectToAction("Inicio");
        }

        public IActionResult VerDepartamento()
        {
            return View(db.Departamentos.ToList());
        }

        public IActionResult VerProovedor()
        {
            return View(db.Proovedors.ToList());
        }
        
        public IActionResult VerPrenda()
        {
            db.Tallas.ToList();
            db.Departamentos.ToList();
            db.Proovedors.ToList();
            return View(db.Prenda.ToList());
        }

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

        [HttpPost]
        public IActionResult ActualizarDepartamento(Departamento departamento)
        {
            db.Entry(departamento).State = EntityState.Modified;
            db.SaveChanges();
            TempData["Actualizar"] = departamento.NombreDepartamento + " fue actualizad@";
            return RedirectToAction("VerDepartamento");
        }

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

        [HttpPost]
        public IActionResult ActualizarProovedor(Proovedor proovedor)
        {
            db.Entry(proovedor).State = EntityState.Modified;
            db.SaveChanges();
            TempData["Actualizar"] = proovedor.NombreProovedor + " fue actualizad@";
            return RedirectToAction("VerProovedor");
        }

        public IActionResult ActualizarPrenda(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Prendum prenda = db.Prenda.Find(id);
            if (prenda == null)
                return NotFound();
            ViewBag.Proovedores = db.Proovedors.ToList();
            ViewBag.Tallas = db.Tallas.ToList();
            ViewBag.Departamentos = db.Departamentos.ToList();
            return View(prenda);
        }

        [HttpPost]
        public IActionResult ActualizarPrenda(Prendum prenda)
        {
            db.Entry(prenda).State = EntityState.Modified;
            db.SaveChanges();
            TempData["Actualizar"] = prenda.NombrePrenda + " fue actualizad@";
            return RedirectToAction("VerPrenda");
        }

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

        [HttpPost]
        public IActionResult EliminarDepartamento(int id)
        {
            Departamento departamento = db.Departamentos.Find(id);
            db.Departamentos.Remove(departamento);
            db.SaveChanges();
            TempData["Eliminado"] = departamento.NombreDepartamento + " fue eliminad@";
            return RedirectToAction("VerDepartamento");
        }

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

        [HttpPost]
        public IActionResult EliminarProovedor(int id)
        {
            Proovedor proovedor = db.Proovedors.Find(id);
            db.Proovedors.Remove(proovedor);
            db.SaveChanges();
            TempData["Eliminado"] = proovedor.NombreProovedor+ " fue eliminad@";
            return RedirectToAction("VerProovedor");
        }

        public IActionResult EliminarPrenda(int? id)
        {
            Prendum prenda = db.Prenda.Find(id);
            db.Prenda.Remove(prenda);
            db.SaveChanges();
            TempData["Eliminado"] = prenda.NombrePrenda + " fue eliminad@";
            return RedirectToAction("VerPrenda");
        }


        public IActionResult AgregarEmpleado()
        {
            ViewBag.Rol = db.Rols.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult AgregarEmpleado(Empleado empleado)
        {
            db.Empleados.Add(empleado);
            db.SaveChanges();
            TempData["Message"] = empleado.NombreEmpleado + " fue registrad@";
            return RedirectToAction("Inicio");
        }

        public IActionResult VerEmpleado()
        {
            db.Rols.ToList();
            return View(db.Empleados.ToList());
        }

        public IActionResult ActualizarEmpleado(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Empleado empleado = db.Empleados.Find(id);
            if (empleado == null)
                return NotFound();
            ViewBag.Rol =  db.Rols.ToList();
            return View(empleado);
        }

        [HttpPost]
        public IActionResult ActualizarEmpleado(Empleado empleado)
        {
            db.Entry(empleado).State = EntityState.Modified;
            db.SaveChanges();
            TempData["Actualizar"] = empleado.NombreEmpleado+ " fue actualizad@";
            return RedirectToAction("VerEmpleado");
        }

        public IActionResult EliminarEmpleado(int? id)
        {
            Empleado empleado = db.Empleados.Find(id);
            db.Empleados.Remove(empleado);
            db.SaveChanges();
            TempData["Eliminado"] = empleado.NombreEmpleado+ " fue eliminad@";
            return RedirectToAction("VerEmpleado");
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
