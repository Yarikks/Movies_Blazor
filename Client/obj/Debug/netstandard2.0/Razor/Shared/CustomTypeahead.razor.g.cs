#pragma checksum "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Shared\CustomTypeahead.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42db8c1c9db373f321b39fec8315e6e529aecbf7"
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
#line 1 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Shared\CustomTypeahead.razor"
using System.Timers;

#line default
#line hidden
    public partial class CustomTypeahead<TItem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Custom Typeahead</h3>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "blazored-typeahead");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "blazored-typeahead__controls");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "type", "text");
            __builder.AddAttribute(9, "class", "blazored-typeahead__input");
            __builder.AddAttribute(10, "autocomplete", "off");
            __builder.AddAttribute(11, "placeholder", 
#line 10 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Shared\CustomTypeahead.razor"
                             Placeholder

#line default
#line hidden
            );
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 13 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Shared\CustomTypeahead.razor"
                          ShowSuggestions

#line default
#line hidden
            ));
            __builder.AddAttribute(13, "onfocusout", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.FocusEventArgs>(this, 
#line 14 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Shared\CustomTypeahead.razor"
                            onfocusout

#line default
#line hidden
            ));
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 11 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Shared\CustomTypeahead.razor"
                             SearchText

#line default
#line hidden
            ));
            __builder.AddAttribute(15, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SearchText = __value, SearchText));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
#line 16 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Shared\CustomTypeahead.razor"
     if (IsSearching)
    {

#line default
#line hidden
            __builder.AddContent(18, "        ");
            __builder.AddMarkupContent(19, "<div class=\"blazored-typeahead__results\">\r\n            <div class=\"blazored-typeahead__result\">\r\n                <span>Loading...</span>\r\n            </div>\r\n        </div>\r\n");
#line 23 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Shared\CustomTypeahead.razor"
    }
    else if (ShouldShowSuggestions())
    {

#line default
#line hidden
            __builder.AddContent(20, "        ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "blazored-typeahead__results");
            __builder.AddMarkupContent(23, "\r\n");
#line 27 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Shared\CustomTypeahead.razor"
             foreach (var item in Suggestions)
            {

#line default
#line hidden
            __builder.AddContent(24, "                ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "blazored-typeahead__result");
            __builder.AddAttribute(27, "tabindex", "0");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 30 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Shared\CustomTypeahead.razor"
                                              () => SelectSuggestion(item)

#line default
#line hidden
            ));
            __builder.AddAttribute(29, "onmouseover", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 31 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Shared\CustomTypeahead.razor"
                                   OnmouseoverSuggestion

#line default
#line hidden
            ));
            __builder.AddAttribute(30, "onmouseout", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 31 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Shared\CustomTypeahead.razor"
                                                                       OnmouseoutSuggestion

#line default
#line hidden
            ));
            __builder.SetKey(
#line 29 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Shared\CustomTypeahead.razor"
                           item

#line default
#line hidden
            );
            __builder.AddMarkupContent(31, "\r\n                    ");
            __builder.AddContent(32, 
#line 32 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Shared\CustomTypeahead.razor"
                     ResultTemplate(item)

#line default
#line hidden
            );
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
#line 34 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Shared\CustomTypeahead.razor"
            }

#line default
#line hidden
            __builder.AddContent(35, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
#line 36 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Shared\CustomTypeahead.razor"
    }
    else if (ShowNotFound())
    {

#line default
#line hidden
            __builder.AddContent(37, "        ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "blazored-typeahead__results");
            __builder.AddMarkupContent(40, "\r\n");
#line 40 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Shared\CustomTypeahead.razor"
             if (NotFoundTemplate != null)
            {

#line default
#line hidden
            __builder.AddContent(41, "                ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "blazored-typeahead__notfound");
            __builder.AddMarkupContent(44, "\r\n                    ");
            __builder.AddContent(45, 
#line 43 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Shared\CustomTypeahead.razor"
                     NotFoundTemplate

#line default
#line hidden
            );
            __builder.AddMarkupContent(46, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n");
#line 45 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Shared\CustomTypeahead.razor"
            }
            else
            {

#line default
#line hidden
            __builder.AddContent(48, "                ");
            __builder.AddMarkupContent(49, "<div class=\"blazored-typeahead__notfound\">\r\n                    No Results Found\r\n                </div>\r\n");
#line 51 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Shared\CustomTypeahead.razor"
            }

#line default
#line hidden
            __builder.AddContent(50, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n");
#line 53 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Shared\CustomTypeahead.razor"
    }

#line default
#line hidden
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 56 "C:\Users\Yorik\Desktop\Blazor_Movies\Movies_Blazor\Client\Shared\CustomTypeahead.razor"
       
    [Parameter] public string Placeholder { get; set; }
    [Parameter] public int MinimumLength { get; set; } = 3;
    [Parameter] public int Debounce { get; set; } = 300;
    [Parameter] public Func<string, Task<IEnumerable<TItem>>> SearchMethod { get; set; }
    [Parameter] public RenderFragment<TItem> ResultTemplate { get; set; }
    [Parameter] public RenderFragment NotFoundTemplate { get; set; }
    [Parameter] public EventCallback<TItem> ValueChanged { get; set; }

    private bool IsSearching = false;
    private bool IsShowingSuggestions = false;
    private string _searchText = string.Empty;
    private Timer _debounceTimer;
    protected TItem[] Suggestions { get; set; } = new TItem[0];

    protected override void OnInitialized()
    {
        _debounceTimer = new Timer();
        _debounceTimer.Interval = Debounce;
        _debounceTimer.AutoReset = false;
        _debounceTimer.Elapsed += Search;

        base.OnInitialized();
    }

    private bool ShowNotFound()
    {
        return !Suggestions.Any() && IsShowingSuggestions;
    }

    private async Task SelectSuggestion(TItem item)
    {
        SearchText = "";
        await ValueChanged.InvokeAsync(item);
    }

    protected async void Search(Object source, ElapsedEventArgs e)
    {
        IsSearching = true;
        IsShowingSuggestions = false;
        await InvokeAsync(StateHasChanged);

        Suggestions = (await SearchMethod.Invoke(_searchText)).ToArray();

        IsSearching = false;
        IsShowingSuggestions = true;
        await InvokeAsync(StateHasChanged);
    }

    private string SearchText
    {
        get => _searchText;
        set
        {
            _searchText = value;

            if (value.Length == 0)
            {
                IsShowingSuggestions = false;
                _debounceTimer.Stop();
                Suggestions = new TItem[0];
            }
            else if (value.Length >= MinimumLength)
            {
                _debounceTimer.Stop();
                _debounceTimer.Start();
            }
        }
    }

    private bool ShouldShowSuggestions()
    {
        return IsShowingSuggestions && Suggestions.Any();
    }

    private void ShowSuggestions()
    {
        if (Suggestions.Any())
        {
            IsShowingSuggestions = true;
        }
    }

    private void onfocusout()
    {
        if (!IsMouseInSuggestion)
        {
            IsShowingSuggestions = false;
        }
    }

    bool IsMouseInSuggestion = false;

    private void OnmouseoverSuggestion()
    {
        IsMouseInSuggestion = true;
    }

    private void OnmouseoutSuggestion()
    {
        IsMouseInSuggestion = false;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
