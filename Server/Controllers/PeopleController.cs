using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Movies_Blazor.Shared.Entities;

namespace Movies_Blazor.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PeopleController : Controller
    {
        private readonly AppDbContext context;
        public PeopleController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Person person)
        {
            context.Add(person);
            await context.SaveChangesAsync();

            return person.Id;
        }
    }
}
