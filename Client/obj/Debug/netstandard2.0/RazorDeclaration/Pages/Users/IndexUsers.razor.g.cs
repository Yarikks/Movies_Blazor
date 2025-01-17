#pragma checksum "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\Users\IndexUsers.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "478c3bfeaa37975847dc77f20d57102ff5b9c6ed"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Movies_Blazor.Client.Pages.Users
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
#line 12 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 13 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/users")]
    public partial class IndexUsers : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 32 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\Users\IndexUsers.razor"
       
    List<UserDTO> Users;
    PaginationDTO paginationDTO = new PaginationDTO();
    int totalAmountPages;

    protected override async Task OnInitializedAsync()
    {
        await LoadUsers();
    }

    private async Task LoadUsers()
    {
        var paginatedResponse = await usersRepository.GetUsers(paginationDTO);
        Users = paginatedResponse.Response;
        totalAmountPages = paginatedResponse.TotalAmountPages;
    }

    private async Task SelectedPage(int page)
    {
        paginationDTO.Page = page;
        await LoadUsers();
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUsersRepository usersRepository { get; set; }
    }
}
#pragma warning restore 1591
