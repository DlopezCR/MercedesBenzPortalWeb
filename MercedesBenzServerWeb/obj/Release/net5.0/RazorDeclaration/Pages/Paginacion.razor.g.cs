// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MercedesBenzServerWeb.Pages
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
    public partial class Paginacion : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "E:\MERCEDES\MercedesBenzWeb\MercedesBenzServerWeb\Pages\Paginacion.razor"
       
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