#pragma checksum "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Shared\InputMarkdown.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff39ee26364368b1a4656ddd6a6b6c5cf54cf997"
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
#line 10 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\_Imports.razor"
using Movies_Blazor.Client.Repository;

#line default
#line hidden
#line 11 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\_Imports.razor"
using Movies_Blazor.Shared.DTOs;

#line default
#line hidden
#line 2 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Shared\InputMarkdown.razor"
using System.Linq.Expressions;

#line default
#line hidden
    public partial class InputMarkdown<TValue> : InputTextArea
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddMarkupContent(1, "\r\n    ");
            __builder.OpenElement(2, "label");
            __builder.AddContent(3, 
#line 5 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Shared\InputMarkdown.razor"
            Label

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(7);
            __builder.AddAttribute(8, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 7 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Shared\InputMarkdown.razor"
                                    CurrentValue

#line default
#line hidden
            ));
            __builder.AddAttribute(9, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => CurrentValue = __value, CurrentValue))));
            __builder.AddAttribute(10, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => CurrentValue));
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n        ");
            __Blazor.Movies_Blazor.Client.Shared.InputMarkdown.TypeInference.CreateValidationMessage_0(__builder, 12, 13, 
#line 8 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Shared\InputMarkdown.razor"
                                For

#line default
#line hidden
            );
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\r\n");
            __builder.OpenElement(17, "div");
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.OpenElement(19, "label");
            __builder.AddContent(20, 
#line 13 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Shared\InputMarkdown.razor"
            Label

#line default
#line hidden
            );
            __builder.AddContent(21, " (preview):");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "markdown-container");
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.OpenComponent<Movies_Blazor.Client.Shared.RenderMarkdown>(26);
            __builder.AddAttribute(27, "MarkdownContent", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 15 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Shared\InputMarkdown.razor"
                                          CurrentValue

#line default
#line hidden
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(28, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 19 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Shared\InputMarkdown.razor"
       
    [Parameter] public Expression<Func<TValue>> For { get; set; }
    [Parameter] public string Label { get; set; }

#line default
#line hidden
    }
}
namespace __Blazor.Movies_Blazor.Client.Shared.InputMarkdown
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
