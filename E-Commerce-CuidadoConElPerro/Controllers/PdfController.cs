using E_Commerce_CuidadoConElPerro.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Rotativa.AspNetCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Threading.Tasks;


namespace E_Commerce_CuidadoConElPerro.Controllers
{
    public class PdfController : Controller
    {
        private readonly CuidadoConElPerroContext db;
        private readonly IWebHostEnvironment env;

        public PdfController(CuidadoConElPerroContext db, IWebHostEnvironment env)
        {
            this.db = db;
            this.env = env;
        }


        public IActionResult Bodega()
        {
            db.Tallas.ToList();
            db.Departamentos.ToList();
            db.Proovedors.ToList();
            return new ViewAsPdf("Bodega", db.Prenda.ToList())
            {
                FileName = "Arriba-Las-Chivas.pdf"
            };
        }

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
    }
}
