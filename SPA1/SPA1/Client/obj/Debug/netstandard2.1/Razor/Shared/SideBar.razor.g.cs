#pragma checksum "C:\Users\Roy\Documents\GitHub\App\SPA1\SPA1\Client\Shared\SideBar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86d7c1affd3c5cf9043841f3e80e08adc99680ff"
// <auto-generated/>
#pragma warning disable 1591
namespace SPA1.Client.Shared
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
#line 1 "C:\Users\Roy\Documents\GitHub\App\SPA1\SPA1\Client\Shared\SideBar.razor"
using SPA1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Roy\Documents\GitHub\App\SPA1\SPA1\Client\Shared\SideBar.razor"
using SPA1.Shared.Models;

#line default
#line hidden
#nullable disable
    public partial class SideBar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "w-auto");
            __builder.AddMarkupContent(2, "\r\n        ");
            __builder.AddMarkupContent(3, "<h2>Watched</h2>\r\n        ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "hidden-scroll");
            __builder.AddMarkupContent(6, "\r\n            ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "flex-column justify-content-between");
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 8 "C:\Users\Roy\Documents\GitHub\App\SPA1\SPA1\Client\Shared\SideBar.razor"
                 if (watchedMovies == null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Roy\Documents\GitHub\App\SPA1\SPA1\Client\Shared\SideBar.razor"
                     for (int i = 0; i < 5; i++)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(10, "                        <div class=\"skeleton-card\"></div>\r\n");
#nullable restore
#line 13 "C:\Users\Roy\Documents\GitHub\App\SPA1\SPA1\Client\Shared\SideBar.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Roy\Documents\GitHub\App\SPA1\SPA1\Client\Shared\SideBar.razor"
                     
                }
                else
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Roy\Documents\GitHub\App\SPA1\SPA1\Client\Shared\SideBar.razor"
                     foreach (var movie in watchedMovies)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "skeleton-card");
            __builder.AddMarkupContent(14, "\r\n                            ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "card bg-dark text-white");
            __builder.AddMarkupContent(17, "\r\n                                ");
            __builder.OpenElement(18, "img");
            __builder.AddAttribute(19, "class", "card-img");
            __builder.AddAttribute(20, "src", 
#nullable restore
#line 20 "C:\Users\Roy\Documents\GitHub\App\SPA1\SPA1\Client\Shared\SideBar.razor"
                                                            movie?.CoverImage

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(21, "alt", "Card image");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                                ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "card-img-overlay extra-info-hover");
            __builder.AddMarkupContent(25, "\r\n                                    ");
            __builder.OpenElement(26, "h5");
            __builder.AddAttribute(27, "class", "card-title");
            __builder.AddContent(28, 
#nullable restore
#line 22 "C:\Users\Roy\Documents\GitHub\App\SPA1\SPA1\Client\Shared\SideBar.razor"
                                                            movie.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                                    ");
            __builder.OpenElement(30, "p");
            __builder.AddAttribute(31, "class", "card-text");
            __builder.AddContent(32, 
#nullable restore
#line 23 "C:\Users\Roy\Documents\GitHub\App\SPA1\SPA1\Client\Shared\SideBar.razor"
                                                          movie?.Duration

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                                    ");
            __builder.OpenElement(34, "p");
            __builder.AddAttribute(35, "class", "card-text");
            __builder.AddContent(36, 
#nullable restore
#line 24 "C:\Users\Roy\Documents\GitHub\App\SPA1\SPA1\Client\Shared\SideBar.razor"
                                                          movie.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
#nullable restore
#line 28 "C:\Users\Roy\Documents\GitHub\App\SPA1\SPA1\Client\Shared\SideBar.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(41, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n\r\n    ");
            __builder.AddMarkupContent(45, @"<style>
        .extra-info-hover {
            opacity: 0;
            top: auto;
            padding: 0;
            background-color: rgba(0,0,0,0.5);
        }

            .extra-info-hover:hover {
                opacity: 1;
            }
    </style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\Roy\Documents\GitHub\App\SPA1\SPA1\Client\Shared\SideBar.razor"
           
        public Movie[] watchedMovies { get; set; }

        protected override async Task OnInitializedAsync()
        {
            watchedMovies = await Http.GetFromJsonAsync<Movie[]>("Movie/filter?Watched=1");
        }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591