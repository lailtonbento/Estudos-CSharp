using basicapi.Model;
namespace basicapi.Service;

public  class PizzariaServiceImp : IPizzariaService
{
    public List<Pizza> Pizzas { get; }
    int nextId = 3;
    public PizzariaServiceImp()
    {
        Pizzas = new List<Pizza>{
            new Pizza { Id = 1, Name = "Classic Italian", IsGlutenFree = false },
            new Pizza { Id = 2, Name = "Veggie", IsGlutenFree = true }
        };
    }

    public List<Pizza> GetAll() => Pizzas;
    public Pizza? GetId(int id) => Pizzas.FirstOrDefault(p => p.Id == id);
    public void AddPizza(Pizza pizza)
    {
        pizza.Id = nextId++;
        Pizzas.Add(pizza);
    }
    public void Delete(int id)
    {
        var pizza = GetId(id);
        if (pizza is null)
        {
            return;
        }
        Pizzas.Remove(pizza);
    }
    public void Update(Pizza pizza)
    {
        var index = Pizzas.FindIndex(p => p.Id == pizza.Id);
        if (index == -1)
            return;

        Pizzas[index] = pizza;
    }

}