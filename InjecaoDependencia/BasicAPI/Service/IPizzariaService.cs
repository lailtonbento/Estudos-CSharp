
using basicapi.Model;

namespace basicapi.Service
{
    public interface IPizzariaService
    {
        List<Pizza> FindAll();
        Pizza? FindById(int id);
        void AddPizza(Pizza pizza);
        void Delete(int id);
        void Update(Pizza pizza);

    }
}