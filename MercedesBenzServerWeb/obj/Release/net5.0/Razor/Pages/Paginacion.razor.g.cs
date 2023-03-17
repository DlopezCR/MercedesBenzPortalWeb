#pragma checksum "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\Paginacion.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64107dd1e5e0b716cb3db05a4850c37a7b848fd9"
// <auto-generated/>
#pragma warning disable 1591
namespace MercedesBenzServerWeb.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\_Imports.razor"
using MercedesBenzServerWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\_Imports.razor"
using MercedesBenzServerWeb.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\_Imports.razor"
using MercedesBenzModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\_Imports.razor"
using Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\_Imports.razor"
using MercedesBenzServerWeb.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\_Imports.razor"
using BlazorPro.Spinkit;

#line default
#line hidden
#nullable disable
    public partial class Paginacion : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\Paginacion.razor"
 if (PaginasTotal > 1)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "nav");
            __builder.OpenElement(1, "ul");
            __builder.AddAttribute(2, "class", "mbz-pagination justify-content-center");
#nullable restore
#line 5 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\Paginacion.razor"
         foreach (var pagina in paginas)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "li");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\Paginacion.razor"
                        () => PaginaSeleccionadaInterno(pagina)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "style", "cursor:pointer;");
            __builder.AddAttribute(6, "class", "mbz-page-item" + " " + (
#nullable restore
#line 9 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\Paginacion.razor"
                                   pagina.Habilitada ? null : " disabled"

#line default
#line hidden
#nullable disable
            ) + " " + (
#nullable restore
#line 9 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\Paginacion.razor"
                                                                             pagina.Activa ? "active" : null

#line default
#line hidden
#nullable disable
            ) + " ");
#nullable restore
#line 10 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\Paginacion.razor"
             if (pagina.Texto == "<")
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "<span class=\"mbz-page-link\" href=\"#\"><img src=\"../image/chevron-back-outline.svg\" style=\"width:20px;height:20px;\"></span>");
#nullable restore
#line 15 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\Paginacion.razor"
            }
            else 

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\Paginacion.razor"
                  if (pagina.Texto == ">")
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(8, "<span class=\"mbz-page-link\" href=\"#\"><img src=\"../image/chevron-forward-outline.svg\" style=\"width:20px;height:20px;\"></span>");
#nullable restore
#line 21 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\Paginacion.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "span");
            __builder.AddAttribute(10, "class", "mbz-page-link");
            __builder.AddAttribute(11, "href", "#");
            __builder.AddContent(12, 
#nullable restore
#line 24 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\Paginacion.razor"
                                                      pagina.Texto

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 25 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\Paginacion.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 27 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\Paginacion.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 30 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\Paginacion.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\Paginacion.razor"
       
    [Parameter] public int PaginaActual { get; set; } = 1;
    [Parameter] public int PaginasTotal { get; set; } = 1;
    [Parameter] public int Radio { get; set; } = 0;
    [Parameter] public EventCallback<int>

    PaginaSeleccionada { get; set; }
    List<Paginas>
    paginas = new List<Paginas>();

    protected override void OnParametersSet()
    {
        CargarPaginas();
    }

    private async Task PaginaSeleccionadaInterno(Paginas pagina)
    {
        if (pagina.Pagina == PaginaActual)
        {
            return;
        }
        if (!pagina.Habilitada)
        {
            return;
        }
        PaginaActual = pagina.Pagina;
        CargarPaginas();
        await PaginaSeleccionada.InvokeAsync(pagina.Pagina);
    }

    private void CargarPaginas()
    {
        paginas = new List<Paginas>();
        var paginaAnteriorHabilitada = PaginaActual != 1;
        var paginaAnterior = (PaginaActual == 1) ? 1 : PaginaActual - 1;
        paginas.Add(new Paginas(paginaAnterior, paginaAnteriorHabilitada, "<"));
        for (int i = 1; i <= PaginasTotal; i++)
        {
            if (i >= PaginaActual - Radio && i <= PaginaActual + Radio)
            {
                //paginas.Add(new Paginas(i) { Activa = PaginaActual == i });
                paginas.Add(new Paginas(false, i, false, $"{i.ToString()}/{PaginasTotal.ToString()}"));
            }
        }
        var paginaSiguienteHabilitada = PaginaActual != PaginasTotal;
        var paginaSiguiente = (PaginaActual == PaginasTotal) ? PaginasTotal : PaginaActual + 1;
        paginas.Add(new Paginas(paginaSiguiente, paginaSiguienteHabilitada, ">"));
    }

    public class Paginas
    {

        public int Pagina { get; set; }
        public bool Habilitada { get; set; }
        public bool Activa { get; set; }
        public string Texto { get; set; }

        public Paginas(int pagina) : this(pagina, true)
        {
        }

        public Paginas(int pagina, bool habilitada) : this(pagina, habilitada, pagina.ToString())
        {
        }

        public Paginas(int pagina, bool habilitada, string texto)
        {
            Pagina = pagina;
            Habilitada = habilitada;
            Texto = texto;
        }
        public Paginas(bool activa, int pagina, bool habilitada, string texto)
        {
            Activa = activa;
            Pagina = pagina;
            Habilitada = habilitada;
            Texto = texto;
        }
    }

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