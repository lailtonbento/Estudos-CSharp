
using basicapi.Model;

namespace basicapi.Service
{
    public interface IPizzariaService
    {
        List<Pizza> GetAll();
        Pizza? GetId(int id);
        void AddPizza(Pizza pizza);
        void Delete(int id);
        void Update(Pizza pizza);

    }
}