#pragma checksum "C:\Users\Martin Gonzalez\source\repos\ProyectoFinal\E-Commerce-CuidadoConElPerro\Views\Inicio\AutentificacionError.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0662769c46c2444f51eb5a2d7dcf0e5bef39882e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inicio_AutentificacionError), @"mvc.1.0.view", @"/Views/Inicio/AutentificacionError.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0662769c46c2444f51eb5a2d7dcf0e5bef39882e", @"/Views/Inicio/AutentificacionError.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5313d35727997053c5c97559180cb53a4b174986", @"/Views/_ViewImports.cshtml")]
    public class Views_Inicio_AutentificacionError : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Martin Gonzalez\source\repos\ProyectoFinal\E-Commerce-CuidadoConElPerro\Views\Inicio\AutentificacionError.cshtml"
  
    ViewData["Title"] = "Sin acceso";
    ViewData["Name"] = @ViewBag.Nombre;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link rel=""apple-touch-icon"" type=""image/png"" href=""https://cpwebassets.codepen.io/assets/favicon/apple-touch-icon-5ae1a0698dcc2402e9712f7d01ed509a57814f994c660df9f7a952f3060705ee.png"" />
<meta name=""apple-mobile-web-app-title"" content=""CodePen"">

<link rel=""shortcut icon"" type=""image/x-icon"" href=""https://cpwebassets.codepen.io/assets/favicon/favicon-aec34940fbc1a6e787974dcd360f2c6b63348d4b1f4e06c77743096d55480f33.ico"" />

<link rel=""mask-icon""");
            BeginWriteAttribute("type", " type=\"", 543, "\"", 550, 0);
            EndWriteAttribute();
            WriteLiteral(@" href=""https://cpwebassets.codepen.io/assets/favicon/logo-pin-8f3771b1072e3c38bd662872f6b673a722f4b3ca2421637d5596661b4e2132cc.svg"" color=""#111"" />



<style>

    .page_404 {
        padding: 40px 0;
        background: #fff;
        font-family: 'Arvo', serif;
    }

        .page_404 img {
            width: 100%;
        }

    .four_zero_four_bg {
        background-image: url(https://cdn.dribbble.com/users/285475/screenshots/2083086/dribbble_1.gif);
        height: 400px;
        background-position: center;
    }


        .four_zero_four_bg h1 {
            font-size: 80px;
        }

        .four_zero_four_bg h3 {
            font-size: 80px;
        }

    .link_404 {
        color: #fff !important;
        padding: 10px 20px;
        background: #39ac31;
        margin: 20px 0;
        display: inline-block;
    }

    .contant_box_404 {
        margin-top: -50px;
    }
</style>


<section class=""page_404"">
    <div class=""container"">
        <div cla");
            WriteLiteral(@"ss=""row"">
            <div class=""col-sm-12 "">
                <div class=""col-sm-10 col-sm-offset-1  text-center"">
                    <div class=""four_zero_four_bg"">
                        <h1 class=""text-center text-danger"">Acceso denegado</h1>
                    </div>
                    <div class=""contant_box_404"">
                        <h3 class=""h2"">
                            Usted no tiene los permisos
                        </h3>
                        <p>para poder seguir!</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

");
            DefineSection("scripts", async() => {
                WriteLiteral(@"

    <script>
        window.console = window.console || function (t) { };
    </script>



    <script>
        if (document.location.search.match(/type=embed/gi)) {
            window.parent.postMessage(""resize"", ""*"");
        }
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
