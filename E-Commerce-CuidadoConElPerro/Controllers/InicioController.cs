﻿using E_Commerce_CuidadoConElPerro.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace E_Commerce_CuidadoConElPerro.Controllers
{
    public class InicioController : Controller
    {
        private readonly CuidadoConElPerroContext db;

        public InicioController(CuidadoConElPerroContext db)
        {
            this.db = db;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login (string usuario, string password)
        {
            var user = await db.Empleados.FirstOrDefaultAsync(x => x.Usuario == usuario && x.Contrasenia == password);
            if(user == null)
            {
                var cliente = await db.Clientes.FirstOrDefaultAsync(x => x.Correo == usuario && x.Contrasenia== password);
                if (cliente == null)
                {
                    TempData["Message"] = "Usuario y/o contraseña incorrecta";
                    return View();
                }
                else
                {
                    var claims = new[]
                {
                    new Claim(ClaimTypes.Name, cliente.NomCliente),
                    new Claim(ClaimTypes.Email, cliente.Correo),
                    new Claim(ClaimTypes.Role, "")
                };
                    var autenticacion = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    await HttpContext.SignInAsync(
                        CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(autenticacion),
                        new AuthenticationProperties
                        {
                            IsPersistent = false
                        });
                    return RedirectToAction("Inicio", "Empleados");
                }
                
            }
            else
            {
                var claims = new[]
                {
                    new Claim(ClaimTypes.Name, user.NombreEmpleado),
                    new Claim(ClaimTypes.Email, user.Usuario),
                    new Claim(ClaimTypes.Role, "")
                };
                var autenticacion = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(autenticacion),
                    new AuthenticationProperties
                    {
                        IsPersistent = false
                    });
                return RedirectToAction("Inicio", "Empleados");
            }
        }

        public IActionResult CrearCliente()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CrearCliente(Cliente cliente)
        {
            db.Clientes.Add(cliente);
            db.SaveChanges();
            TempData["Registro"] = cliente.NomCliente+ " fue registrado";
            return View("Login");
        }
    }
}