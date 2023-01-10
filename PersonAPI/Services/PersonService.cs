using Microsoft.EntityFrameworkCore;
using PersonAPI.Models;
using PersonAPI.Models.Database;
using System.Data;

namespace PersonAPI.Services
{
    public class PersonService : IPersonService
    {

        private readonly PersonContext _context;

        public PersonService(PersonContext context) {
            _context= context;
        }
        public async void CreatePerson(Person person)
        {
            _context.Add(person);
            await _context.SaveChangesAsync();
        }

        public async void Delete(int id)
        {
            var person = PersonExists(id);
            _context.Remove(person);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Person>> FindAllPersons()
        {
            return await _context.Persons.ToListAsync();
        }

        public async Task<Person> FindById(int id)
        {
            var person = await _context.Persons.FindAsync(id);
            return person;
        }

        public bool PersonExists(int id)
        {
            return (_context.Persons?.Any(e => e.Id == id)).GetValueOrDefault();
        }

        public async void Update(Person person)
        {
            if (PersonExists(person.Id) == false) {
                throw new PersonNotFoundException($"Person not found with ID: {person.Id}");
            }
            try
            { 
            _context.Update(person);
            await _context.SaveChangesAsync();
            }
            catch (DBConcurrencyException e) 
            {
                throw new DBConcurrencyException(e.Message);
            }
        }
    }
}
