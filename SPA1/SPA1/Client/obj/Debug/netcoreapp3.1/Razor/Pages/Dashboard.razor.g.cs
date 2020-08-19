#pragma checksum "C:\Users\Roy\Documents\GitHub\App\SPA1\SPA1\Client\Pages\Dashboard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "415ea04977e6df6b4d62d2e10659cf1944629a88"
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
using SPA1.Shared.Models;

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
            __builder.AddMarkupContent(10, "<h2>Movies</h2>\r\n");
#nullable restore
#line 11 "C:\Users\Roy\Documents\GitHub\App\SPA1\SPA1\Client\Pages\Dashboard.razor"
             foreach (var movie in movies)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "skeleton-card");
            __builder.AddMarkupContent(14, "\r\n");
#nullable restore
#line 14 "C:\Users\Roy\Documents\GitHub\App\SPA1\SPA1\Client\Pages\Dashboard.razor"
                     if (movie != null)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(15, "                    ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "card bg-dark text-white");
            __builder.AddMarkupContent(18, "\r\n                        ");
            __builder.OpenElement(19, "img");
            __builder.AddAttribute(20, "class", "card-img");
            __builder.AddAttribute(21, "src", 
#nullable restore
#line 17 "C:\Users\Roy\Documents\GitHub\App\SPA1\SPA1\Client\Pages\Dashboard.razor"
                                                    movie.CoverImage

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(22, "alt", "Card image");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                        ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "card-img-overlay");
            __builder.AddMarkupContent(26, "\r\n                            ");
            __builder.OpenElement(27, "h5");
            __builder.AddAttribute(28, "class", "card-title");
            __builder.AddContent(29, 
#nullable restore
#line 19 "C:\Users\Roy\Documents\GitHub\App\SPA1\SPA1\Client\Pages\Dashboard.razor"
                                                    movie.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                            ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "extra-info-hover");
            __builder.AddMarkupContent(33, "\r\n                                ");
            __builder.OpenElement(34, "p");
            __builder.AddAttribute(35, "class", "card-text");
            __builder.AddContent(36, 
#nullable restore
#line 21 "C:\Users\Roy\Documents\GitHub\App\SPA1\SPA1\Client\Pages\Dashboard.razor"
                                                      movie.Duration

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                                ");
            __builder.OpenElement(38, "p");
            __builder.AddAttribute(39, "class", "card-text");
            __builder.AddContent(40, 
#nullable restore
#line 22 "C:\Users\Roy\Documents\GitHub\App\SPA1\SPA1\Client\Pages\Dashboard.razor"
                                                      movie.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n");
#nullable restore
#line 26 "C:\Users\Roy\Documents\GitHub\App\SPA1\SPA1\Client\Pages\Dashboard.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(45, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n");
#nullable restore
#line 28 "C:\Users\Roy\Documents\GitHub\App\SPA1\SPA1\Client\Pages\Dashboard.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(47, "            <div class=\"skeleton-block-small\"></div>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n\r\n    ");
            __builder.AddMarkupContent(50, @"<div class=""flex-grow-1 flex-shrink-0"">
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
            __builder.AddMarkupContent(51, "\r\n");
            __builder.AddMarkupContent(52, "<style>\r\n    .extra-info-hover {\r\n        display: none;\r\n    }\r\n\r\n    .extra-info-hover :hover{\r\n        display: inline;\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "C:\Users\Roy\Documents\GitHub\App\SPA1\SPA1\Client\Pages\Dashboard.razor"
       
    private Movie[] movies;

    protected override async Task OnInitializedAsync()
    {
        movies = await Http.GetFromJsonAsync<Movie[]>("Movie");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
