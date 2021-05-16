using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_CuidadoConElPerro.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Tienda()
        {
            return View();
        }
    }
}
