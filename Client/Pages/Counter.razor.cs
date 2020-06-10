using Microsoft.AspNetCore.Components;
using Movies_Blazor.Shared.Entities;
using System;
using System.Collections.Generic;

namespace Movies_Blazor.Client.Pages
{
    public partial class Counter
    {
        [Inject] SingletonService singleton { get; set; }
        [Inject] TransientService transient { get; set; }
        private List<Movie> movies;
        private int currentCount = 0;

        protected override void OnInitialized()
        {
            movies = new List<Movie>()
            {
                new Movie(){Title = "Joker", ReleaseDate = new DateTime(2019, 7, 2) },
                new Movie(){Title = "Avangers", ReleaseDate = new DateTime(2016, 11, 23) }
            };
        }
        private void IncrementCount()
        {
            currentCount++;
            transient.Value = currentCount;
            singleton.Value = currentCount;
        }
    }
}
