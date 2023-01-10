using Microsoft.EntityFrameworkCore;

namespace PersonAPI.Models.Database
{
    public class PersonContext : DbContext
    {
        public PersonContext(DbContextOptions<PersonContext> options) 
            : base(options) 
        {
        }

        public DbSet<Person> Persons { get; set; }
    }
}
