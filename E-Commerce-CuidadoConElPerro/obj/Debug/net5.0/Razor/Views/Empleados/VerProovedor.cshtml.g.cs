#pragma checksum "C:\Users\Martin Gonzalez\source\repos\ProyectoFinal\E-Commerce-CuidadoConElPerro\Views\Empleados\VerProovedor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "355c387b54716649b3ea7f2f55c2f648cde662e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empleados_VerProovedor), @"mvc.1.0.view", @"/Views/Empleados/VerProovedor.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"355c387b54716649b3ea7f2f55c2f648cde662e5", @"/Views/Empleados/VerProovedor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5313d35727997053c5c97559180cb53a4b174986", @"/Views/_ViewImports.cshtml")]
    public class Views_Empleados_VerProovedor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<E_Commerce_CuidadoConElPerro.Models.Proovedor>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ActualizarProovedor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EliminarProovedor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Martin Gonzalez\source\repos\ProyectoFinal\E-Commerce-CuidadoConElPerro\Views\Empleados\VerProovedor.cshtml"
  
    ViewData["Title"] = "Proovedores";
    ViewData["Name"] = @ViewBag.Nombre;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container-fluid\">\r\n    <div class=\"row\">\r\n        <div class=\"col-xs-12\">\r\n            <h1 class=\"page-header\">\r\n                Tabla de proovedores\r\n            </h1>\r\n            <span id=\"Eliminar\" class=\"d-none\">");
#nullable restore
#line 14 "C:\Users\Martin Gonzalez\source\repos\ProyectoFinal\E-Commerce-CuidadoConElPerro\Views\Empleados\VerProovedor.cshtml"
                                          Write(TempData["Eliminado"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            <span id=\"Actualizar\" class=\"d-none\">");
#nullable restore
#line 15 "C:\Users\Martin Gonzalez\source\repos\ProyectoFinal\E-Commerce-CuidadoConElPerro\Views\Empleados\VerProovedor.cshtml"
                                            Write(TempData["Actualizar"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
            <p>
                En este apartado podremos ver todos los <b>proovedores</b> de la tienda.
            </p>
            <div class=""align-items-sm-center"">
                <table id=""example"" class=""table table-striped table-bordered"">
                    <thead>
                        <tr>
                            <th style=""width:160px"">Proovedor</th>
                            <th style=""width:160px"">Telefono</th>
                            <th style=""width:220px"">Acciones</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 29 "C:\Users\Martin Gonzalez\source\repos\ProyectoFinal\E-Commerce-CuidadoConElPerro\Views\Empleados\VerProovedor.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 32 "C:\Users\Martin Gonzalez\source\repos\ProyectoFinal\E-Commerce-CuidadoConElPerro\Views\Empleados\VerProovedor.cshtml"
                               Write(item.NombreProovedor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 33 "C:\Users\Martin Gonzalez\source\repos\ProyectoFinal\E-Commerce-CuidadoConElPerro\Views\Empleados\VerProovedor.cshtml"
                               Write(item.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "355c387b54716649b3ea7f2f55c2f648cde662e57547", async() => {
                WriteLiteral("<i class=\"fas fa-sync-alt\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "C:\Users\Martin Gonzalez\source\repos\ProyectoFinal\E-Commerce-CuidadoConElPerro\Views\Empleados\VerProovedor.cshtml"
                                                                          WriteLiteral(item.IdProovedor);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "355c387b54716649b3ea7f2f55c2f648cde662e59923", async() => {
                WriteLiteral("<i class=\"fas fa-trash-alt\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 36 "C:\Users\Martin Gonzalez\source\repos\ProyectoFinal\E-Commerce-CuidadoConElPerro\Views\Empleados\VerProovedor.cshtml"
                                                                        WriteLiteral(item.IdProovedor);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 39 "C:\Users\Martin Gonzalez\source\repos\ProyectoFinal\E-Commerce-CuidadoConElPerro\Views\Empleados\VerProovedor.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"


    <script>
        $(document).ready(function () {
            var message = $('#Actualizar').text();
            if (message !== '') {
                toastr.info(message, ""Proovedor actualizado"", {
                    ""closeButton"": true,
                    ""progressBar"": true,
                    ""positionClass"": ""toast-bottom-right"",
                    ""preventDuplicates"": true,
                });
            }
        });
    </script>

    <script>
        $(document).ready(function () {
            var message = $('#Eliminar').text();
            if (message !== '') {
                toastr.error(message, ""Proovedor eliminado"", {
                    ""closeButton"": true,
                    ""progressBar"": true,
                    ""positionClass"": ""toast-bottom-right"",
                    ""preventDuplicates"": true,
                });
            }
        });
    </script>

    <script>
        $(document).ready(function () {
            $('#example').DataTable(");
                WriteLiteral(@"{
                language: {
                    processing: ""En proceso"",
                    search: ""Buscar"",
                    lengthMenu: ""Agrupar de _MENU_ ítems"",
                    info: ""Mostrando del ítem  _START_ al _END_ de un total de _TOTAL_ ítems"",
                    infoEmpty: ""No existen datos"",
                    infoFiltered: ""(Filtrado de _MAX_ elementos en total)"",
                    infoPostFix: """",
                    loadingRecords: ""Cargando..."",
                    zeroRecords: ""No se encontraron datos con tu busqueda"",
                    emptyTable: ""No hay datos disponibles en la tabla"",
                    paginate: {
                        first: ""Primero"",
                        previous: ""Anterior"",
                        next: ""Siguiente"",
                        last: ""Ultimo""
                    },
                    aria: {
                        sortAscending: "": Ascendente"",
                        sortDescending: "": Descendente""
        ");
                WriteLiteral("            }\r\n                },\r\n                scrollY: 400,\r\n                lengthMenu: [[10, 25, -1], [10, 25, \"All\"]],\r\n            });\r\n        });\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<E_Commerce_CuidadoConElPerro.Models.Proovedor>> Html { get; private set; }
    }
}
#pragma warning restore 1591
