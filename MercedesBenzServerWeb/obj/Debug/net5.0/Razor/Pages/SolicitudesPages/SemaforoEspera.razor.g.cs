#pragma checksum "E:\MERCEDES\MercedesBenzWeb\MercedesBenzServerWeb\Pages\SolicitudesPages\SemaforoEspera.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6339d09931d4e99d893ee324a5c8796ce6c8190b"
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
    public partial class SemaforoEspera : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "mbz-card-ficha-sem");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "d-flex");
            __builder.AddAttribute(4, "style", "height: 66px;");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "mbz-ficha-sem-1");
            __builder.OpenComponent<MercedesBenzServerWeb.Pages.SemaforoColor>(7);
            __builder.AddAttribute(8, "NombreSemaforo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 4 "E:\MERCEDES\MercedesBenzWeb\MercedesBenzServerWeb\Pages\SolicitudesPages\SemaforoEspera.razor"
                                            Semaforo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "Estilo", "mbz-span-sem-36");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "mbz-ficha-sem-2");
            __builder.OpenElement(13, "span");
            __builder.AddAttribute(14, "class", "mbz-font-STextOffice-B-16 mbz-text-dark");
            __builder.AddContent(15, 
#nullable restore
#line 7 "E:\MERCEDES\MercedesBenzWeb\MercedesBenzServerWeb\Pages\SolicitudesPages\SemaforoEspera.razor"
                                                                   Texto

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "mbz-ficha-sem-3");
            __builder.OpenComponent<BlazorPro.Spinkit.CircleFade>(19);
            __builder.AddAttribute(20, "Center", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 10 "E:\MERCEDES\MercedesBenzWeb\MercedesBenzServerWeb\Pages\SolicitudesPages\SemaforoEspera.razor"
                                true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "Size", "20px");
            __builder.AddAttribute(22, "Color", "#232F3B");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "E:\MERCEDES\MercedesBenzWeb\MercedesBenzServerWeb\Pages\SolicitudesPages\SemaforoEspera.razor"
       
    [Parameter] public string Semaforo { get; set; }
    [Parameter] public string Texto { get; set; }

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
