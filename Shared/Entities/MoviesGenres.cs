﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Movies_Blazor.Shared.Entities
{
    public class MoviesGenres
    {
        public int MovieId { get; set; }
        public int GenreId { get; set; }
        public Movie Movie { get; set; }
        public Genre Genre { get; set; }
    }
}
