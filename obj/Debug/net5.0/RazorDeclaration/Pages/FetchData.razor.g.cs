// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorTest.Pages
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\User\Desktop\Repositories\BlazorTest\blazortest\_Imports.razor"
using System.Net.Http

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\User\Desktop\Repositories\BlazorTest\blazortest\_Imports.razor"
using Microsoft.AspNetCore.Authorization

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\User\Desktop\Repositories\BlazorTest\blazortest\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization

#nullable disable
    ;
#nullable restore
#line 4 "C:\Users\User\Desktop\Repositories\BlazorTest\blazortest\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms

#nullable disable
    ;
#nullable restore
#line 5 "C:\Users\User\Desktop\Repositories\BlazorTest\blazortest\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing

#nullable disable
    ;
#nullable restore
#line 6 "C:\Users\User\Desktop\Repositories\BlazorTest\blazortest\_Imports.razor"
using Microsoft.AspNetCore.Components.Web

#nullable disable
    ;
#nullable restore
#line 7 "C:\Users\User\Desktop\Repositories\BlazorTest\blazortest\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization

#nullable disable
    ;
#nullable restore
#line 8 "C:\Users\User\Desktop\Repositories\BlazorTest\blazortest\_Imports.razor"
using Microsoft.JSInterop

#nullable disable
    ;
#nullable restore
#line 9 "C:\Users\User\Desktop\Repositories\BlazorTest\blazortest\_Imports.razor"
using BlazorTest

#nullable disable
    ;
#nullable restore
#line 10 "C:\Users\User\Desktop\Repositories\BlazorTest\blazortest\_Imports.razor"
using BlazorTest.Shared

#nullable disable
    ;
#nullable restore
#line 11 "C:\Users\User\Desktop\Repositories\BlazorTest\blazortest\_Imports.razor"
using MudBlazor

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\User\Desktop\Repositories\BlazorTest\blazortest\Pages\FetchData.razor"
 using BlazorTest.Data

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Components.RouteAttribute(
    // language=Route,Component
#nullable restore
#line 1 "C:\Users\User\Desktop\Repositories\BlazorTest\blazortest\Pages\FetchData.razor"
      "/fetchdata"

#line default
#line hidden
#nullable disable
    )]
    #nullable restore
    public partial class FetchData : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\User\Desktop\Repositories\BlazorTest\blazortest\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }

#line default
#line hidden
#nullable disable

        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 4 "C:\Users\User\Desktop\Repositories\BlazorTest\blazortest\Pages\FetchData.razor"
        WeatherForecastService

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 4 "C:\Users\User\Desktop\Repositories\BlazorTest\blazortest\Pages\FetchData.razor"
                               ForecastService

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
    }
}
#pragma warning restore 1591
