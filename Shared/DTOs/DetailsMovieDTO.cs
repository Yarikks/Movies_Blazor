﻿using Movies_Blazor.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies_Blazor.Shared.DTOs
{
    public class DetailsMovieDTO
    {
        public Movie Movie { get; set; }
        public List<Genre> Genres { get; set; }
        public List<Person> Actors { get; set; }
        public double AverageVote { get; set; }
        public int UserVote { get; set; }
    }
}
