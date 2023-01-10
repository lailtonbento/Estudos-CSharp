namespace basicapi.Controller;

using System;
using basicapi.Model;
using basicapi.Service;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class PizzariaController : ControllerBase
{
    private readonly IPizzariaService _pizzariaService;
    PizzariaController(IPizzariaService pizzariaService)
    {
        _pizzariaService = pizzariaService;
    }

    [HttpGet("{id}")]
    public ActionResult<Pizza> GetById(int id)
    {
        var pizza = _pizzariaService.FindById(id);

        if (pizza == null)
            return NotFound();

        return pizza;
    }

    [HttpPost]
    public IActionResult Create(Pizza pizza)
    {
        _pizzariaService.AddPizza(pizza);
        return CreatedAtAction(nameof(Create), new { id = pizza.Id }, pizza);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, Pizza pizza)
    {
        if (id != pizza.Id)
            return BadRequest();

        var existingPizza = _pizzariaService.FindById(id);
        if (existingPizza is null)
            return NotFound();

        _pizzariaService.Update(pizza);

        return NoContent();
    }
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var pizza = _pizzariaService.FindById(id);

        if (pizza is null)
            return NotFound();

        _pizzariaService.Delete(id);

        return NoContent();
    }


}