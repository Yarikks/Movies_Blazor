#pragma checksum "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\Movies\MovieForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3161a1b43a0352cc2c5b8e653fe4e0989cd1a4ff"
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
    public partial class MovieForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 74 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\Movies\MovieForm.razor"
       
    [Parameter] public Movie Movie { get; set; }
    [Parameter] public EventCallback OnValidSubmit { get; set; }
    [Parameter] public List<Genre> SelectedGenres { get; set; } = new List<Genre>();
    [Parameter] public List<Genre> NotSelectedGenres { get; set; } = new List<Genre>();
    [Parameter] public List<Person> SelectedActors { get; set; } = new List<Person>();

    private List<MultipleSelectorModel> Selected = new List<MultipleSelectorModel>();
    private List<MultipleSelectorModel> NotSelected = new List<MultipleSelectorModel>();
    private string imageUrl;

    protected override void OnInitialized()
    {

        Selected = SelectedGenres.Select(g => new MultipleSelectorModel(g.Id.ToString(), g.Name)).ToList();
        NotSelected = NotSelectedGenres.Select(g => new MultipleSelectorModel(g.Id.ToString(), g.Name)).ToList();

        if (!string.IsNullOrEmpty(Movie.Poster))
        {
            imageUrl = Movie.Poster;
            Movie.Poster = null;
        }
    }

    private void PosterSelected(string imageBase64)
    {
        Movie.Poster = imageBase64;
        imageUrl = null;
        Console.WriteLine(imageBase64);
    }

    private async Task<IEnumerable<Person>> SearchMethod(string searchText)
    {
        return await personRepository.GetPeopleByName(searchText);
    }

    private async Task OnDataAnnotationsValidated()
    {
        Movie.MoviesGenres = Selected
            .Select(mg => new MoviesGenres { GenreId = int.Parse(mg.Key) }).ToList();

        Movie.MoviesActors = SelectedActors
            .Select(ma => new MoviesActors { PersonId = ma.Id, Character = ma.Character }).ToList();

        if (!string.IsNullOrWhiteSpace(Movie.Poster)) { imageUrl = null; }

        await OnValidSubmit.InvokeAsync(null);
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPersonRepository personRepository { get; set; }
    }
}
#pragma warning restore 1591
