using Movies_Blazor.Shared.DTOs;
using Movies_Blazor.Shared.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Movies_Blazor.Client.Repository
{
    public interface IPersonRepository
    {
        Task CreatePerson(Person person);
        Task DeletePerson(int Id);
        Task<PaginatedResponse<List<Person>>> GetPeople(PaginationDTO paginationDTO);
        Task<List<Person>> GetPeopleByName(string name);
        Task<Person> GetPersonById(int id);
        Task UpdatePerson(Person person);
    }
}
