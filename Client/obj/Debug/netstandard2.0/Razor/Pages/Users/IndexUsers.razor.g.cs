#pragma checksum "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\Users\IndexUsers.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "478c3bfeaa37975847dc77f20d57102ff5b9c6ed"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenComponent<Movies_Blazor.Client.Shared.Pagination>(0);
            __builder.AddAttribute(1, "CurrentPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#line 4 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\Users\IndexUsers.razor"
                          paginationDTO.Page

#line default
#line hidden
            ));
            __builder.AddAttribute(2, "SelectedPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#line 4 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\Users\IndexUsers.razor"
                                                            SelectedPage

#line default
#line hidden
            )));
            __builder.AddAttribute(3, "TotalAmountPages", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#line 4 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\Users\IndexUsers.razor"
                                                                                            totalAmountPages

#line default
#line hidden
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __Blazor.Movies_Blazor.Client.Pages.Users.IndexUsers.TypeInference.CreateGenericList_0(__builder, 5, 6, 
#line 6 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\Users\IndexUsers.razor"
                   Users

#line default
#line hidden
            , 7, (__builder2) => {
                __builder2.AddMarkupContent(8, "\r\n        ");
                __builder2.OpenElement(9, "table");
                __builder2.AddAttribute(10, "class", "table");
                __builder2.AddMarkupContent(11, "\r\n            ");
                __builder2.AddMarkupContent(12, "<thead>\r\n                <tr>\r\n                    <th></th>\r\n                    <th>User</th>\r\n                </tr>\r\n            </thead>\r\n            ");
                __builder2.OpenElement(13, "tbody");
                __builder2.AddMarkupContent(14, "\r\n");
#line 16 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\Users\IndexUsers.razor"
                 foreach (var user in Users)
                {

#line default
#line hidden
                __builder2.AddContent(15, "                    ");
                __builder2.OpenElement(16, "tr");
                __builder2.AddMarkupContent(17, "\r\n                        ");
                __builder2.OpenElement(18, "td");
                __builder2.AddMarkupContent(19, "\r\n                            ");
                __builder2.OpenElement(20, "a");
                __builder2.AddAttribute(21, "href", "/users/edit/" + (
#line 20 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\Users\IndexUsers.razor"
                                                  user.UserId

#line default
#line hidden
                ));
                __builder2.AddAttribute(22, "class", "btn btn-success");
                __builder2.AddContent(23, "Edit");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n                        ");
                __builder2.OpenElement(26, "td");
                __builder2.AddMarkupContent(27, "\r\n                            ");
                __builder2.AddContent(28, 
#line 23 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\Users\IndexUsers.razor"
                             user.Email

#line default
#line hidden
                );
                __builder2.AddMarkupContent(29, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n");
#line 26 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\Users\IndexUsers.razor"
                }

#line default
#line hidden
                __builder2.AddContent(32, "            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n    ");
            }
            );
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
namespace __Blazor.Movies_Blazor.Client.Pages.Users.IndexUsers
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateGenericList_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<TItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Movies_Blazor.Client.Shared.GenericList<TItem>>(seq);
        __builder.AddAttribute(__seq0, "List", __arg0);
        __builder.AddAttribute(__seq1, "WholeListTemplate", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
