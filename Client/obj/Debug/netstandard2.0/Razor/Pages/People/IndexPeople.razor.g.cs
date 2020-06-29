#pragma checksum "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\People\IndexPeople.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1108d3faf10dd42e0df931a74e7591a56957984e"
// <auto-generated/>
#pragma warning disable 1591
namespace Movies_Blazor.Client.Pages.People
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/people")]
    public partial class IndexPeople : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Index People</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, "<div class=\"form-group\">\r\n    <a class=\"btn btn-info\" href=\"/person/create\">New Person</a>\r\n</div>\r\n\r\n");
            __builder.OpenComponent<Movies_Blazor.Client.Shared.Pagination>(2);
            __builder.AddAttribute(3, "CurrentPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#line 9 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\People\IndexPeople.razor"
                          paginationDTO.Page

#line default
#line hidden
            ));
            __builder.AddAttribute(4, "TotalAmountPages", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#line 9 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\People\IndexPeople.razor"
                                                                totalAmountPages

#line default
#line hidden
            ));
            __builder.AddAttribute(5, "SelectedPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#line 9 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\People\IndexPeople.razor"
                                                                                                SelectedPage

#line default
#line hidden
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n\r\n");
            __Blazor.Movies_Blazor.Client.Pages.People.IndexPeople.TypeInference.CreateGenericList_0(__builder, 7, 8, 
#line 11 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\People\IndexPeople.razor"
                   People

#line default
#line hidden
            , 9, (__builder2) => {
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.OpenElement(11, "table");
                __builder2.AddAttribute(12, "class", "table table-striped");
                __builder2.AddMarkupContent(13, "\r\n            ");
                __builder2.AddMarkupContent(14, "<thead>\r\n                <tr>\r\n                    <th></th>\r\n                    <th>Name</th>\r\n                </tr>\r\n            </thead>\r\n            ");
                __builder2.OpenElement(15, "tbody");
                __builder2.AddMarkupContent(16, "\r\n");
#line 21 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\People\IndexPeople.razor"
                 foreach (var item in People)
                {

#line default
#line hidden
                __builder2.AddContent(17, "                    ");
                __builder2.OpenElement(18, "tr");
                __builder2.AddMarkupContent(19, "\r\n                        ");
                __builder2.OpenElement(20, "td");
                __builder2.AddMarkupContent(21, "\r\n                            ");
                __builder2.OpenElement(22, "a");
                __builder2.AddAttribute(23, "class", "btn btn-success");
                __builder2.AddAttribute(24, "href", "/person/edit/" + (
#line 25 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\People\IndexPeople.razor"
                                                                           item.Id

#line default
#line hidden
                ));
                __builder2.AddContent(25, "Edit");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n                            ");
                __builder2.OpenElement(27, "button");
                __builder2.AddAttribute(28, "class", "btn btn-danger");
                __builder2.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 26 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\People\IndexPeople.razor"
                                                                       () => DeletePerson(item.Id)

#line default
#line hidden
                ));
                __builder2.AddContent(30, "Delete");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n                        ");
                __builder2.OpenElement(33, "td");
                __builder2.AddContent(34, 
#line 28 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\People\IndexPeople.razor"
                             item.Name

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n");
#line 30 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\People\IndexPeople.razor"
                }

#line default
#line hidden
                __builder2.AddContent(37, "            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n    ");
            }
            );
        }
        #pragma warning restore 1998
#line 35 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\People\IndexPeople.razor"
       
    List<Person> People;
    PaginationDTO paginationDTO = new PaginationDTO() { RecordsPerPage = 1 };
    private int totalAmountPages;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            await LoadPeople();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    private async Task LoadPeople()
    {
        var paginatedResponse = await personRepository.GetPeople(paginationDTO);
        People = paginatedResponse.Response;
        totalAmountPages = paginatedResponse.TotalAmountPages;
    }

    private async Task SelectedPage(int page)
    {
        paginationDTO.Page = page;
        await LoadPeople();
    }

    private async Task DeletePerson(int Id)
    {
        await personRepository.DeletePerson(Id);
        await LoadPeople();
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPersonRepository personRepository { get; set; }
    }
}
namespace __Blazor.Movies_Blazor.Client.Pages.People.IndexPeople
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
