using Movies_Blazor.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies_Blazor.Client.Helpers
{
    public interface IRepository
    {
        List<Movie> GetMovies();
    }
}
