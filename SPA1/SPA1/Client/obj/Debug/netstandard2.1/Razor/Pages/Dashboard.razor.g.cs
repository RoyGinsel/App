#pragma checksum "C:\Users\Roy\Documents\GitHub\App\SPA1\SPA1\Client\Pages\Dashboard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1bc454047184b284915276258d8ab4de4b562cc"
// <auto-generated/>
#pragma warning disable 1591
namespace SPA1.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Roy\Documents\GitHub\App\SPA1\SPA1\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Roy\Documents\GitHub\App\SPA1\SPA1\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Roy\Documents\GitHub\App\SPA1\SPA1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Roy\Documents\GitHub\App\SPA1\SPA1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Roy\Documents\GitHub\App\SPA1\SPA1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Roy\Documents\GitHub\App\SPA1\SPA1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Roy\Documents\GitHub\App\SPA1\SPA1\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Roy\Documents\GitHub\App\SPA1\SPA1\Client\_Imports.razor"
using SPA1.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Roy\Documents\GitHub\App\SPA1\SPA1\Client\_Imports.razor"
using SPA1.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Roy\Documents\GitHub\App\SPA1\SPA1\Client\Pages\Dashboard.razor"
using SPA1.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/dasboard")]
    public partial class Dashboard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Dashboard</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "d-flex");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "w-auto");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "flex-column justify-content-between");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.AddMarkupContent(10, "<h2>Weather</h2>\r\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "skeleton-card");
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.AddContent(14, 
#nullable restore
#line 12 "C:\Users\Roy\Documents\GitHub\App\SPA1\SPA1\Client\Pages\Dashboard.razor"
                  (MarkupString)myMarkup

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n            <div class=\"skeleton-block-small\"></div>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\r\n    ");
            __builder.AddMarkupContent(19, @"<div class=""flex-grow-1 flex-shrink-0"">
        <div class=""d-flex justify-content-center "">
            <div class=""skeleton-block-large""></div>
        </div>

        <div class=""d-flex justify-content-around"">
            <div class=""skeleton-card""></div>
            <div class=""skeleton-block-small""></div>
        </div>
    </div>
");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\Roy\Documents\GitHub\App\SPA1\SPA1\Client\Pages\Dashboard.razor"
       
    string myMarkup = "<p class='markup'>This is a <em>markup string</em>.</p> <p class='markup'>This is a <em>markup string</em>.</p>";

    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
