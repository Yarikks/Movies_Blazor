#pragma checksum "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Shared\InputImage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a609407ac40180fa432cda6518e348b8f6630e83"
// <auto-generated/>
#pragma warning disable 1591
namespace Movies_Blazor.Client.Shared
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
#line 1 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Shared\InputImage.razor"
using System.IO;

#line default
#line hidden
#line 3 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Shared\InputImage.razor"
using Blazor.FileReader;

#line default
#line hidden
    public partial class InputImage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddMarkupContent(1, "\r\n    ");
            __builder.OpenElement(2, "label");
            __builder.AddContent(3, 
#line 6 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Shared\InputImage.razor"
            Label

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "type", "file");
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#line 8 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Shared\InputImage.razor"
                                                          ImageFileSelected

#line default
#line hidden
            ));
            __builder.AddAttribute(10, "accept", ".jpg,.jpeg,.png");
            __builder.AddElementReferenceCapture(11, (__value) => {
#line 8 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Shared\InputImage.razor"
                                 inputElement = __value;

#line default
#line hidden
            }
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n\r\n");
            __builder.OpenElement(15, "div");
            __builder.AddMarkupContent(16, "\r\n");
#line 13 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Shared\InputImage.razor"
     if (imageBase64 != null)
    {

#line default
#line hidden
            __builder.AddContent(17, "        ");
            __builder.OpenElement(18, "div");
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "style", "margin:10px");
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "img");
            __builder.AddAttribute(24, "src", "data:image/jpeg;base64," + " " + (
#line 17 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Shared\InputImage.razor"
                                                   imageBase64

#line default
#line hidden
            ));
            __builder.AddAttribute(25, "style", "width:400px");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
#line 20 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Shared\InputImage.razor"
    }

#line default
#line hidden
            __builder.AddMarkupContent(29, "\r\n");
#line 22 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Shared\InputImage.razor"
     if (ImageUrl != null)
    {

#line default
#line hidden
            __builder.AddContent(30, "        ");
            __builder.OpenElement(31, "div");
            __builder.AddMarkupContent(32, "\r\n            ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "style", "margin:10px");
            __builder.AddMarkupContent(35, "\r\n                ");
            __builder.OpenElement(36, "img");
            __builder.AddAttribute(37, "src", 
#line 26 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Shared\InputImage.razor"
                           ImageUrl

#line default
#line hidden
            );
            __builder.AddAttribute(38, "style", "width:400px");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n");
#line 29 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Shared\InputImage.razor"
    }

#line default
#line hidden
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 32 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Shared\InputImage.razor"
       
    [Parameter] public string Label { get; set; } = "Image";
    [Parameter] public string ImageUrl { get; set; }
    [Parameter] public EventCallback<string> OnSelectedImage { get; set; }
    private string imageBase64;
    ElementReference inputElement;

    async Task ImageFileSelected()
    {
        foreach(var file in await fileReaderService.CreateReference(inputElement).EnumerateFilesAsync())
        {
            using(MemoryStream memoryStream = await file.CreateMemoryStreamAsync(4 * 1024))
            {
                var imageBytes = new byte[memoryStream.Length];
                memoryStream.Read(imageBytes, 0, (int)memoryStream.Length);
                imageBase64 = Convert.ToBase64String(imageBytes);

                await OnSelectedImage.InvokeAsync(imageBase64);

                ImageUrl = null;
                StateHasChanged();
            }
        }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazor.FileReader.IFileReaderService fileReaderService { get; set; }
    }
}
#pragma warning restore 1591
