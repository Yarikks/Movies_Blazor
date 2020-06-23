#pragma checksum "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\Movies\DetailsMovie.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "068ddced6f7188a0050d2de23d47cddc57a68f42"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Movies_Blazor.Client.Pages.Movies
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
#line 10 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\_Imports.razor"
using Movies_Blazor.Client.Repository;

#line default
#line hidden
#line 11 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\_Imports.razor"
using Movies_Blazor.Shared.DTOs;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/movie/{MovieId:int}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/movie/{MovieId:int}/{MovieName}")]
    public partial class DetailsMovie : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 56 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\Movies\DetailsMovie.razor"
       
    [Parameter] public int MovieId { get; set; }
    [Parameter] public string MovieName { get; set; }
    private RenderFragment<Genre> linkGenre = (genre) =>

#line default
#line hidden
        (__builder2) => {
            __builder2.OpenElement(0, "a");
            __builder2.AddAttribute(1, "href", "movies/search?genreId=" + (
#line 59 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\Movies\DetailsMovie.razor"
                                                                                         genre.Id

#line default
#line hidden
            ));
            __builder2.AddContent(2, 
#line 59 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\Movies\DetailsMovie.razor"
                                                                                                    genre.Name

#line default
#line hidden
            );
            __builder2.CloseElement();
        }
#line 59 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\Movies\DetailsMovie.razor"
                                                                                                                  ;
DetailsMovieDTO model;

protected async override Task OnInitializedAsync()
{
model = await moviesRepository.GetDetailsMovieDTO(MovieId);
}

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMoviesRepository moviesRepository { get; set; }
    }
}
#pragma warning restore 1591
