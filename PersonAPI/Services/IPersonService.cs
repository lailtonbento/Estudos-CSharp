using PersonAPI.Models;

namespace PersonAPI.Services
{
    public interface IPersonService
    {
        Task<List<Person>> FindAllPersons();
        Task<Person> FindById(int id);
        void CreatePerson(Person person);
        void Delete(int id);
        void Update(Person person);
        bool PersonExists(int id);
    }
}
