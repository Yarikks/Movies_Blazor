#pragma checksum "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\Genres\CreateGenre.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70c4bc6d79d4523120cbf1c94a0ee28e74f653c9"
// <auto-generated/>
#pragma warning disable 1591
namespace Movies_Blazor.Client.Pages.Genres
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/genre/create")]
    public partial class CreateGenre : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>CreateGenre</h3>\r\n\r\n");
            __builder.OpenComponent<Movies_Blazor.Client.Pages.Genres.GenreForm>(1);
            __builder.AddAttribute(2, "Genre", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Movies_Blazor.Shared.Entities.Genre>(
#line 5 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\Genres\CreateGenre.razor"
                  genre

#line default
#line hidden
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#line 5 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\Genres\CreateGenre.razor"
                                        Create

#line default
#line hidden
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#line 7 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\Genres\CreateGenre.razor"
       
    private Genre genre = new Genre();

    private void Create()
    {
        Console.WriteLine("Create method.");
        Console.WriteLine(genre.Name);
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
