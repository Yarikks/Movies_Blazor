#pragma checksum "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "617e725011037b98a2cf99cea5a873feb2fd6f61"
// <auto-generated/>
#pragma warning disable 1591
namespace Movies_Blazor.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\_Imports.razor"
using Movies_Blazor.Client;

#line default
#line hidden
#line 7 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\_Imports.razor"
using Movies_Blazor.Client.Shared;

#line default
#line hidden
#line 8 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\_Imports.razor"
using Movies_Blazor.Client.Helpers;

#line default
#line hidden
#line 9 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\_Imports.razor"
using Movies_Blazor.Shared.Entities;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "p");
            __builder.AddContent(1, "Hello, ");
            __builder.AddContent(2, 
#line 3 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\Index.razor"
           StringUtilities.CustomToUpper(name)

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenElement(4, "p");
            __builder.AddContent(5, " Add two numbers - 2 + 2 = ");
            __builder.AddContent(6, 
#line 5 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\Index.razor"
                                2 + 2

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __builder.OpenElement(8, "button");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 7 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\Index.razor"
                   WriteInLog

#line default
#line hidden
            ));
            __builder.AddContent(10, "Click me");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\'\r\n\r\n");
            __builder.OpenElement(12, "div");
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.AddMarkupContent(14, "<h3>Movies</h3>\r\n    ");
            __builder.AddMarkupContent(15, "<h4>Foreach loop</h4>\r\n");
#line 12 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\Index.razor"
     if (movies == null)
    {
        

#line default
#line hidden
            __builder.AddContent(16, "Loading... Wait, please");
#line 14 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\Index.razor"
                                            
    }
    else
    {
        

#line default
#line hidden
#line 18 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\Index.razor"
         foreach (var movie in movies)
        {

#line default
#line hidden
            __builder.AddContent(17, "            ");
            __builder.OpenElement(18, "p");
            __builder.AddContent(19, "Title: ");
            __builder.AddContent(20, 
#line 20 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\Index.razor"
                        (MarkupString)movie.Title

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.OpenElement(22, "p");
            __builder.AddContent(23, "Release Date: ");
            __builder.OpenElement(24, "b");
            __builder.AddContent(25, 
#line 21 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\Index.razor"
                                 movie.ReleaseDate.ToString("dd MMM yyyy")

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
#line 22 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\Index.razor"
        }

#line default
#line hidden
            __builder.AddContent(27, "        ");
            __builder.AddMarkupContent(28, "<h4>For loop</h4>\r\n");
#line 25 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\Index.razor"
         for (var i = 0; i < movies.Count; i++)
        {

#line default
#line hidden
            __builder.AddContent(29, "            ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "style", "background-color:" + " " + (
#line 27 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\Index.razor"
                                            i % 2 == 0 ? "aqua" : "tomato"

#line default
#line hidden
            ));
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.OpenElement(33, "p");
            __builder.AddContent(34, 
#line 28 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\Index.razor"
                     i+1

#line default
#line hidden
            );
            __builder.AddContent(35, ") Title: ");
            __builder.OpenElement(36, "b");
            __builder.AddContent(37, 
#line 28 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\Index.razor"
                                      movies[i].Title

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                ");
            __builder.OpenElement(39, "p");
            __builder.AddContent(40, "Release Date: ");
            __builder.OpenElement(41, "b");
            __builder.AddContent(42, 
#line 29 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\Index.razor"
                                     movies[i].ReleaseDate.ToString("dd MMM yyyy")

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n");
#line 31 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\Index.razor"
        }

#line default
#line hidden
#line 31 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\Index.razor"
         
    }

#line default
#line hidden
            __builder.AddMarkupContent(45, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 36 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\Index.razor"
      
    string name = "Yarik";

    List<Movie> movies;

    protected async override Task OnInitializedAsync()
    {
        await Task.Delay(3000);
        movies = new List<Movie>()
        {
            new Movie(){Title = "<b>Spider-Man: Far From Home</b>", ReleaseDate = new DateTime(2019, 7, 2) },
            new Movie(){Title = "<i>Moana</i>", ReleaseDate = new DateTime(2016, 11, 23) },
            new Movie(){Title = "Inception", ReleaseDate = new DateTime(2010, 7, 16) },
        };
    }

    void WriteInLog()
    {
        Console.WriteLine("I've been clicked. (from method)");
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
