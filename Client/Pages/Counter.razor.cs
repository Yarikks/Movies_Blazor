using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Movies_Blazor.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Movies_Blazor.Client.Pages
{
    public partial class Counter
    {
        [Inject] SingletonService singleton { get; set; }
        [Inject] TransientService transient { get; set; }
        [Inject] IJSRuntime js { get; set; }

        private List<Movie> movies;
        private int currentCount = 0;
        private static int currentCountStatic = 0;


        protected override void OnInitialized()
        {
            movies = new List<Movie>()
            {
                new Movie(){Title = "Joker", ReleaseDate = new DateTime(2019, 7, 2) },
                new Movie(){Title = "Avangers", ReleaseDate = new DateTime(2016, 11, 23) }
            };
        }
        private async Task IncrementCount()
        {
            currentCount++;
            currentCountStatic++;
            transient.Value = currentCount;
            singleton.Value = currentCount;
            await js.InvokeVoidAsync("dotnetStaticInvocation");
        }

        [JSInvokable]
        public static Task<int> GetCurrentCount()
        {
            return Task.FromResult(currentCountStatic);
        }
    }
}
