using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Movies_Blazor.Server.Helpers;
using Movies_Blazor.Shared.DTOs;
using Movies_Blazor.Shared.Entities;

namespace Movies_Blazor.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PeopleController : Controller
    {
        private readonly AppDbContext context;
        private readonly IFileStorageService fileStorageService;
        private readonly IMapper mapper;

        public PeopleController(AppDbContext context, IFileStorageService fileStorageService, IMapper mapper)
        {
            this.context = context;
            this.fileStorageService = fileStorageService;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<Person>>> Get([FromQuery] PaginationDTO paginationDTO)
        {
            var queryable = context.People.AsQueryable();
            await HttpContext.InsertPaginationParametersInResponse(queryable, paginationDTO.RecordrsPerPage);

            return await queryable.Paginate(paginationDTO).ToListAsync();
        }

        [HttpGet("search/{searchText}")]
        public async Task<ActionResult<List<Person>>> FilterByName(string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText)) { return new List<Person>(); }
            return await context.People.Where(p => p.Name.Contains(searchText)).Take(5).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Person>> Get(int Id)
        {
            var person = await context.People.FirstOrDefaultAsync(x => x.Id == Id);

            if(person == null) { return NotFound(); }

            return person;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Person person)
        {
            if (!string.IsNullOrEmpty(person.Picture))
            {
                var personPicture = Convert.FromBase64String(person.Picture);
                person.Picture = await fileStorageService.SaveFile(personPicture, "jpg", "people");
            }

            context.Add(person);
            await context.SaveChangesAsync();

            return person.Id;
        }

        [HttpPut]
        public async Task<ActionResult> Put(Person person)
        {
            var personDb = await context.People.FirstOrDefaultAsync(x => x.Id == person.Id);

            if(personDb == null) { return NotFound(); }

            personDb = mapper.Map(person, personDb);

            if (!string.IsNullOrWhiteSpace(person.Picture))
            {
                var personPicture = Convert.FromBase64String(person.Picture);
                personDb.Picture = await fileStorageService.EditFile(personPicture, "jpg", "people", personDb.Picture);
            }

            await context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var person = await context.People.FirstOrDefaultAsync(x => x.Id == id);
            if (person == null)
            {
                return NotFound();
            }

            context.Remove(person);
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}
