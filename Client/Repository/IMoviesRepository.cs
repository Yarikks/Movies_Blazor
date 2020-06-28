﻿using Movies_Blazor.Shared.DTOs;
using Movies_Blazor.Shared.Entities;
using System.Threading.Tasks;

namespace Movies_Blazor.Client.Repository
{
    public interface IMoviesRepository
    {
        Task<int> CreateMovie(Movie movie);
        Task DeleteMovie(int Id);
        Task<DetailsMovieDTO> GetDetailsMovieDTO(int id);
        Task<IndexPageDTO> GetIndexPageDTO();
        Task<MovieUpdateDTO> GetMovieForUpdate(int id);
        Task UpdateMovie(Movie movie);
    }
}
