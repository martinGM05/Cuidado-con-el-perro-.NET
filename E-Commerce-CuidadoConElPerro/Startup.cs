using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using E_Commerce_CuidadoConElPerro;
using E_Commerce_CuidadoConElPerro.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using System.Net;

namespace E_Commerce_CuidadoConElPerro
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                    .AddCookie(option =>
                    {
                        option.LoginPath = new PathString("/Inicio/AutentificacionError");
                        option.AccessDeniedPath = new PathString("/Inicio/AutentificacionError");
                        option.Events = new CookieAuthenticationEvents()
                        {
                            OnSigningIn = async context =>
                            {
                                var principal = context.Principal;
                                if (principal.HasClaim(c => c.Type == ClaimTypes.NameIdentifier))
                                {
                                    if (principal.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value == "1")
                                    {
                                        var claimsIdentity = principal.Identity as ClaimsIdentity;
                                        claimsIdentity.AddClaim(new Claim(ClaimTypes.Role, "Admin"));
                                    }
                                }
                            },
                            OnSignedIn = async context =>
                            {
                                await Task.CompletedTask;
                            },
                            OnValidatePrincipal = async context =>
                            {
                                await Task.CompletedTask;
                            }
                        };
                    });
            services.AddDbContext<CuidadoConElPerroContext>(
                options =>
                options.UseSqlServer(Configuration.GetConnectionString("CuidadoConElPerro"))
                );
            services.AddSession(option => option.IdleTimeout = TimeSpan.FromMinutes(30));
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseSession();
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Inicio}/{action=Login}");
            });

            Rotativa.AspNetCore.RotativaConfiguration.Setup(env.WebRootPath, "../Rotativa");

        }
    }
}
