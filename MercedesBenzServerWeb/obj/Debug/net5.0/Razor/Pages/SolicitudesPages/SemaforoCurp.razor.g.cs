#pragma checksum "E:\MERCEDES\MercedesBenzWeb\MercedesBenzServerWeb\Pages\SolicitudesPages\SemaforoCurp.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19426bf414b800bd23620343443a4dc445be5703"
// <auto-generated/>
#pragma warning disable 1591
namespace MercedesBenzServerWeb.Pages.SolicitudesPages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\MERCEDES\MercedesBenzWeb\MercedesBenzServerWeb\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\MERCEDES\MercedesBenzWeb\MercedesBenzServerWeb\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\MERCEDES\MercedesBenzWeb\MercedesBenzServerWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\MERCEDES\MercedesBenzWeb\MercedesBenzServerWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\MERCEDES\MercedesBenzWeb\MercedesBenzServerWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\MERCEDES\MercedesBenzWeb\MercedesBenzServerWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\MERCEDES\MercedesBenzWeb\MercedesBenzServerWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\MERCEDES\MercedesBenzWeb\MercedesBenzServerWeb\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\MERCEDES\MercedesBenzWeb\MercedesBenzServerWeb\_Imports.razor"
using MercedesBenzServerWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\MERCEDES\MercedesBenzWeb\MercedesBenzServerWeb\_Imports.razor"
using MercedesBenzServerWeb.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\MERCEDES\MercedesBenzWeb\MercedesBenzServerWeb\_Imports.razor"
using MercedesBenzModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\MERCEDES\MercedesBenzWeb\MercedesBenzServerWeb\_Imports.razor"
using Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\MERCEDES\MercedesBenzWeb\MercedesBenzServerWeb\_Imports.razor"
using MercedesBenzServerWeb.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\MERCEDES\MercedesBenzWeb\MercedesBenzServerWeb\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\MERCEDES\MercedesBenzWeb\MercedesBenzServerWeb\_Imports.razor"
using BlazorPro.Spinkit;

#line default
#line hidden
#nullable disable
    public partial class SemaforoCurp : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", "idSemaforoCurp");
            __builder.AddAttribute(2, "style", "padding: 20px;");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "pb-2");
            __builder.OpenElement(5, "span");
            __builder.AddAttribute(6, "class", "mbz-font-STextOffice-B-16 mbz-text-dark");
            __builder.AddContent(7, 
#nullable restore
#line 3 "E:\MERCEDES\MercedesBenzWeb\MercedesBenzServerWeb\Pages\SolicitudesPages\SemaforoCurp.razor"
                                                               Model.mensaje

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "mbz-card-ficha-carnet mb-3");
            __builder.AddAttribute(11, "style", "padding: 20px;");
            __builder.OpenElement(12, "table");
            __builder.AddAttribute(13, "class", "mbz-font-STextOffice-14 mbz-text-dark");
            __builder.AddAttribute(14, "style", "width: 100%;");
            __builder.OpenElement(15, "tbody");
            __builder.OpenElement(16, "tr");
            __builder.AddAttribute(17, "style", "vertical-align: baseline;");
            __builder.OpenElement(18, "td");
            __builder.AddAttribute(19, "style", "width: 33%; padding: 10px 40px;");
            __builder.AddMarkupContent(20, "<span class=\"mbz-font-STextOffice-B-14\">Nombre:</span>\r\n                        <br>\r\n                        ");
            __builder.OpenElement(21, "span");
            __builder.AddContent(22, 
#nullable restore
#line 13 "E:\MERCEDES\MercedesBenzWeb\MercedesBenzServerWeb\Pages\SolicitudesPages\SemaforoCurp.razor"
                               Model.datos_validacion.nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                        <br><br>\r\n                        ");
            __builder.AddMarkupContent(24, "<span class=\"mbz-font-STextOffice-B-14\">Apellido paterno: </span>\r\n                        <br>\r\n                        ");
            __builder.OpenElement(25, "span");
            __builder.AddContent(26, 
#nullable restore
#line 17 "E:\MERCEDES\MercedesBenzWeb\MercedesBenzServerWeb\Pages\SolicitudesPages\SemaforoCurp.razor"
                               Model.datos_validacion.paterno

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                        <br><br>\r\n                        ");
            __builder.AddMarkupContent(28, "<span class=\"mbz-font-STextOffice-B-14\">Apellido materno:</span>\r\n                        <br>\r\n                        ");
            __builder.OpenElement(29, "span");
            __builder.AddContent(30, 
#nullable restore
#line 21 "E:\MERCEDES\MercedesBenzWeb\MercedesBenzServerWeb\Pages\SolicitudesPages\SemaforoCurp.razor"
                               Model.datos_validacion.materno

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                        <br><br>\r\n                        ");
            __builder.AddMarkupContent(32, "<span class=\"mbz-font-STextOffice-B-14\">Fecha de nacimiento:</span>\r\n                        <br>\r\n                        ");
            __builder.OpenElement(33, "span");
            __builder.AddContent(34, 
#nullable restore
#line 25 "E:\MERCEDES\MercedesBenzWeb\MercedesBenzServerWeb\Pages\SolicitudesPages\SemaforoCurp.razor"
                               Model.datos_validacion.fecha_nacimiento

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                        <br><br>\r\n                            ");
            __builder.AddMarkupContent(36, "<span class=\"mbz-font-STextOffice-B-14\">Curp:</span>\r\n                        <br>\r\n                        ");
            __builder.OpenElement(37, "span");
            __builder.AddContent(38, 
#nullable restore
#line 29 "E:\MERCEDES\MercedesBenzWeb\MercedesBenzServerWeb\Pages\SolicitudesPages\SemaforoCurp.razor"
                               Model.datos_validacion.curp

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                    ");
            __builder.OpenElement(40, "td");
            __builder.AddAttribute(41, "style", "width: 33%; padding: 10px 40px;");
            __builder.AddMarkupContent(42, "<span class=\"mbz-font-STextOffice-B-14\">Sexo:</span>\r\n                        <br>\r\n                        ");
            __builder.OpenElement(43, "span");
            __builder.AddContent(44, 
#nullable restore
#line 34 "E:\MERCEDES\MercedesBenzWeb\MercedesBenzServerWeb\Pages\SolicitudesPages\SemaforoCurp.razor"
                               Model.datos_validacion.sexo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                        <br><br>\r\n                            ");
            __builder.AddMarkupContent(46, "<span class=\"mbz-font-STextOffice-B-14\">Estado de nacimiento: </span>\r\n                        <br>\r\n                        ");
            __builder.OpenElement(47, "span");
            __builder.AddContent(48, 
#nullable restore
#line 38 "E:\MERCEDES\MercedesBenzWeb\MercedesBenzServerWeb\Pages\SolicitudesPages\SemaforoCurp.razor"
                               Model.datos_validacion.estado_nacimiento

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                        <br><br>\r\n                            ");
            __builder.AddMarkupContent(50, "<span class=\"mbz-font-STextOffice-B-14\">Pais de nacimiento:</span>\r\n                        <br>\r\n                        ");
            __builder.OpenElement(51, "span");
            __builder.AddContent(52, 
#nullable restore
#line 42 "E:\MERCEDES\MercedesBenzWeb\MercedesBenzServerWeb\Pages\SolicitudesPages\SemaforoCurp.razor"
                               Model.datos_validacion.pais_nacimiento

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                        <br><br>\r\n                            ");
            __builder.AddMarkupContent(54, "<span class=\"mbz-font-STextOffice-B-14\">Clave pais de nacimiento:</span>\r\n                        <br>\r\n                        ");
            __builder.OpenElement(55, "span");
            __builder.AddContent(56, 
#nullable restore
#line 46 "E:\MERCEDES\MercedesBenzWeb\MercedesBenzServerWeb\Pages\SolicitudesPages\SemaforoCurp.razor"
                               Model.datos_validacion.clave_pais_nacimiento

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                    ");
            __builder.OpenElement(58, "td");
            __builder.AddAttribute(59, "style", "width: 33%; padding: 10px 40px;");
            __builder.AddMarkupContent(60, "<span class=\"mbz-font-STextOffice-B-14\">Entidad de registro:</span>\r\n                        <br>\r\n                        ");
            __builder.OpenElement(61, "span");
            __builder.AddContent(62, 
#nullable restore
#line 51 "E:\MERCEDES\MercedesBenzWeb\MercedesBenzServerWeb\Pages\SolicitudesPages\SemaforoCurp.razor"
                               Model.datos_validacion.entidad_registro

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                        <br><br>\r\n                            ");
            __builder.AddMarkupContent(64, "<span class=\"mbz-font-STextOffice-B-14\">Municipio de registro: </span>\r\n                        <br>\r\n                        ");
            __builder.OpenElement(65, "span");
            __builder.AddContent(66, 
#nullable restore
#line 55 "E:\MERCEDES\MercedesBenzWeb\MercedesBenzServerWeb\Pages\SolicitudesPages\SemaforoCurp.razor"
                               Model.datos_validacion.municipio_registro

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                        <br><br>\r\n                            ");
            __builder.AddMarkupContent(68, "<span class=\"mbz-font-STextOffice-B-14\">Año de registro:</span>\r\n                        <br>\r\n                        ");
            __builder.OpenElement(69, "span");
            __builder.AddContent(70, 
#nullable restore
#line 59 "E:\MERCEDES\MercedesBenzWeb\MercedesBenzServerWeb\Pages\SolicitudesPages\SemaforoCurp.razor"
                               Model.datos_validacion.anio_registro

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                        <br><br>\r\n                            ");
            __builder.AddMarkupContent(72, "<span class=\"mbz-font-STextOffice-B-14\">Número de acta:</span>\r\n                        <br>\r\n                        ");
            __builder.OpenElement(73, "span");
            __builder.AddContent(74, 
#nullable restore
#line 63 "E:\MERCEDES\MercedesBenzWeb\MercedesBenzServerWeb\Pages\SolicitudesPages\SemaforoCurp.razor"
                               Model.datos_validacion.numero_acta

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 72 "E:\MERCEDES\MercedesBenzWeb\MercedesBenzServerWeb\Pages\SolicitudesPages\SemaforoCurp.razor"
       
    [Parameter] public CurpResponse Model { get; set; }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BusquedaRequest Busqueda { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserCredential Credential { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppState AppState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
