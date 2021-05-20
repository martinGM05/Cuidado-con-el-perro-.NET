using E_Commerce_CuidadoConElPerro.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
        public IActionResult Tienda()
        {
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
    }
}
