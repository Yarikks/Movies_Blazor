﻿using Movies_Blazor.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies_Blazor.Client.Repository
{
    public interface IGenreRepository
    {
        Task CreateGenre(Genre genre);
        Task<Genre> GetGenre(int Id);
        Task<List<Genre>> GetGenres();
        Task UpdateGenre(Genre genre);
        Task DeleteGenre(int Id);
    }
}
