#pragma checksum "C:\Users\Martin Gonzalez\source\repos\ProyectoFinal\E-Commerce-CuidadoConElPerro\Views\Pdf\Bodega.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58547cf3acee8f2f4aed0d00b9d3c2977d83c97a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pdf_Bodega), @"mvc.1.0.view", @"/Views/Pdf/Bodega.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Martin Gonzalez\source\repos\ProyectoFinal\E-Commerce-CuidadoConElPerro\Views\_ViewImports.cshtml"
using E_Commerce_CuidadoConElPerro;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Martin Gonzalez\source\repos\ProyectoFinal\E-Commerce-CuidadoConElPerro\Views\_ViewImports.cshtml"
using E_Commerce_CuidadoConElPerro.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58547cf3acee8f2f4aed0d00b9d3c2977d83c97a", @"/Views/Pdf/Bodega.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5313d35727997053c5c97559180cb53a4b174986", @"/Views/_ViewImports.cshtml")]
    public class Views_Pdf_Bodega : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<E_Commerce_CuidadoConElPerro.Models.Prendum>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Martin Gonzalez\source\repos\ProyectoFinal\E-Commerce-CuidadoConElPerro\Views\Pdf\Bodega.cshtml"
  
    ViewData["Title"] = "Bodega";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-xs-12"">
            <h1 class=""page-header text-center"">
                Bodega
            </h1>
            <p class=""text-center"">
                En este apartado podremos ver todas las <b>prendas</b> de la bodega.
            </p>
            <div class=""align-items-sm-center"">

                <table class=""table table-bordered"">
                    <thead>
                        <tr>
                            <th style=""width: 160px"">Prenda</th>
                            <th style=""width: 160px"">Genero</th>
                            <th style=""width: 160px"">Precio</th>
                            <th style=""width: 160px"">Cantidad</th>
                            <th style=""width: 160px"">Descripción</th>
                            <th style=""width: 160px"">Talla</th>
                            <th style=""width: 160px"">Departamento</th>
                            <th style=""width: 160px"">Proovedor<");
            WriteLiteral("/th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 32 "C:\Users\Martin Gonzalez\source\repos\ProyectoFinal\E-Commerce-CuidadoConElPerro\Views\Pdf\Bodega.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 35 "C:\Users\Martin Gonzalez\source\repos\ProyectoFinal\E-Commerce-CuidadoConElPerro\Views\Pdf\Bodega.cshtml"
                               Write(item.NombrePrenda);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 36 "C:\Users\Martin Gonzalez\source\repos\ProyectoFinal\E-Commerce-CuidadoConElPerro\Views\Pdf\Bodega.cshtml"
                               Write(item.Genero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 37 "C:\Users\Martin Gonzalez\source\repos\ProyectoFinal\E-Commerce-CuidadoConElPerro\Views\Pdf\Bodega.cshtml"
                               Write(item.Precio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 38 "C:\Users\Martin Gonzalez\source\repos\ProyectoFinal\E-Commerce-CuidadoConElPerro\Views\Pdf\Bodega.cshtml"
                               Write(item.Cantidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 39 "C:\Users\Martin Gonzalez\source\repos\ProyectoFinal\E-Commerce-CuidadoConElPerro\Views\Pdf\Bodega.cshtml"
                               Write(item.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 40 "C:\Users\Martin Gonzalez\source\repos\ProyectoFinal\E-Commerce-CuidadoConElPerro\Views\Pdf\Bodega.cshtml"
                               Write(item.IdTallaNavigation.NombreTalla);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 41 "C:\Users\Martin Gonzalez\source\repos\ProyectoFinal\E-Commerce-CuidadoConElPerro\Views\Pdf\Bodega.cshtml"
                               Write(item.IdDepartamentoNavigation.NombreDepartamento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 42 "C:\Users\Martin Gonzalez\source\repos\ProyectoFinal\E-Commerce-CuidadoConElPerro\Views\Pdf\Bodega.cshtml"
                               Write(item.IdProovedorNavigation.NombreProovedor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 44 "C:\Users\Martin Gonzalez\source\repos\ProyectoFinal\E-Commerce-CuidadoConElPerro\Views\Pdf\Bodega.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<E_Commerce_CuidadoConElPerro.Models.Prendum>> Html { get; private set; }
    }
}
#pragma warning restore 1591
