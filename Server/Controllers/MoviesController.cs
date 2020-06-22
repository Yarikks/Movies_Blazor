using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Movies_Blazor.Server.Helpers;
using Movies_Blazor.Shared.Entities;

namespace Movies_Blazor.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : Controller
    {
        private readonly AppDbContext context;
        private readonly IFileStorageService fileStorageService;
        public MoviesController(AppDbContext context, IFileStorageService fileStorageService)
        {
            this.context = context;
            this.fileStorageService = fileStorageService;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Movie movie)
        {
            if (!string.IsNullOrEmpty(movie.Poster))
            {
                var personPicture = Convert.FromBase64String(movie.Poster);
                movie.Poster = await fileStorageService.SaveFile(personPicture, "jpg", "movies");
            }

            context.Add(movie);
            await context.SaveChangesAsync();

            return movie.Id;
        }
    }
}
