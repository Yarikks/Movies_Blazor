#pragma checksum "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b2783f7233db11b59f9c03b86258034d0fe49e7"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddAttribute(1, "style", "color:" + " " + (
#line 3 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\Counter.razor"
                   AppState.Color

#line default
#line hidden
            ));
            __builder.AddContent(2, "Counter");
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "style", "display:flex");
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "style", "width:150px");
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "select");
            __builder.AddAttribute(11, "class", "form-control");
            __builder.AddAttribute(12, "style", "margin-top: 15px");
            __builder.AddAttribute(13, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 7 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\Counter.razor"
                       AppState.Color

#line default
#line hidden
            ));
            __builder.AddAttribute(14, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => AppState.Color = __value, AppState.Color));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.OpenElement(16, "option");
            __builder.AddAttribute(17, "value", "green");
            __builder.AddContent(18, "Green");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "option");
            __builder.AddAttribute(21, "value", "red");
            __builder.AddContent(22, "Red");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.OpenElement(24, "option");
            __builder.AddAttribute(25, "value", "blue");
            __builder.AddContent(26, "Blue");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n    ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "style", "width:150px");
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.OpenElement(33, "select");
            __builder.AddAttribute(34, "class", "form-control");
            __builder.AddAttribute(35, "style", "margin-top: 15px");
            __builder.AddAttribute(36, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 14 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\Counter.razor"
                       AppState.Size

#line default
#line hidden
            ));
            __builder.AddAttribute(37, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => AppState.Size = __value, AppState.Size));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(38, "\r\n            ");
            __builder.OpenElement(39, "option");
            __builder.AddAttribute(40, "value", "12px");
            __builder.AddContent(41, "12px");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n            ");
            __builder.OpenElement(43, "option");
            __builder.AddAttribute(44, "value", "20px");
            __builder.AddContent(45, "20px");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n            ");
            __builder.OpenElement(47, "option");
            __builder.AddAttribute(48, "value", "30px");
            __builder.AddContent(49, "30px");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n\r\n");
            __builder.OpenElement(54, "p");
            __builder.AddAttribute(55, "style", "font-size:" + " " + (
#line 22 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\Counter.razor"
                      AppState.Size

#line default
#line hidden
            ));
            __builder.AddContent(56, "Current count: ");
            __builder.AddContent(57, 
#line 22 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\Counter.razor"
                                                     currentCount

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n");
            __builder.OpenElement(59, "p");
            __builder.AddContent(60, "Singleton count: ");
            __builder.AddContent(61, 
#line 23 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\Counter.razor"
                     singleton.Value

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n");
            __builder.OpenElement(63, "p");
            __builder.AddContent(64, "Transient count: ");
            __builder.AddContent(65, 
#line 24 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\Counter.razor"
                     transient.Value

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n\r\n");
            __builder.OpenElement(67, "button");
            __builder.AddAttribute(68, "class", "btn btn-primary");
            __builder.AddAttribute(69, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 26 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\Counter.razor"
                                          IncrementCount

#line default
#line hidden
            ));
            __builder.AddContent(70, "Click me");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n\r\n");
            __builder.OpenElement(72, "button");
            __builder.AddAttribute(73, "class", "btn btn-primary");
            __builder.AddAttribute(74, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 28 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\Counter.razor"
                                          IncrementCountJavascript

#line default
#line hidden
            ));
            __builder.AddContent(75, "Click me JS");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n\r\n");
            __builder.OpenElement(77, "input");
            __builder.AddAttribute(78, "type", "number");
            __builder.AddAttribute(79, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 30 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Pages\Counter.razor"
                            currentCount

#line default
#line hidden
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(80, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => currentCount = __value, currentCount, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
