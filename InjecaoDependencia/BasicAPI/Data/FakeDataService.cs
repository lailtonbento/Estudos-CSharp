using Microsoft.EntityFrameworkCore;
using basicapi.Model;
namespace basicapi.Data
{
    public class FakeDataService
    {

        private DatabaseContext _context;

        public FakeDataService(DatabaseContext context)
        {
            context = _context;
        }

        public void SeedData()
        {
            Pizza pizza1 = new Pizza(1, "Mozzarella", false);
            Pizza pizza2 = new Pizza(2, "Veggie", true);

        _context.Pizza.AddRange(pizza1, pizza2);
        _context.SaveChanges();
        }

    }
}
