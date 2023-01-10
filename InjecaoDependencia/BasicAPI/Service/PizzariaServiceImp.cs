using basicapi.Model;
using basicapi.Data;
using basicapi.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace basicapi.Service;

public class PizzariaServiceImp : IPizzariaService
{
    private readonly DatabaseContext _context;
    public List<Pizza> Pizzas { get; }
    int nextId = 3;
    public PizzariaServiceImp(DatabaseContext context)
    {
        _context = context;
    }

    public List<Pizza> FindAll()
    {
        return _context.Pizza.ToList();
    }
    public Pizza? FindById(int id) => Pizzas.FirstOrDefault(p => p.Id == id);
    public void AddPizza(Pizza pizza)
    {
        _context.Add(pizza);
        _context.SaveChanges();
    }
    public void Delete(int id)
    {
        var pizza = _context.Pizza.Find(id);
        _context.Pizza.Remove(pizza);
        _context.SaveChanges();
    }
    public void Update(Pizza pizza)
    {
        if (!_context.Pizza.Any(x => x.Id == pizza.Id))
        {
            throw new NotFoundException("Id not found");
        }
        try
        {
            _context.Update(pizza);
            _context.SaveChanges();
        }
        catch (DbUpdateConcurrencyException e)
        {
            throw new DbConcurrencyException(e.Message);
        }
    }

}