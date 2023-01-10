using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonAPI.Models;
using PersonAPI.Models.Database;
using PersonAPI.Services;

namespace PersonAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PersonController : Controller
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService, PersonContext personContext)
        {
            _personService = personService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Person>>> GetAllPersons()
        {
            if (_personService == null) return NotFound();

            return await _personService.FindAllPersons();
        }

        // GET METHOD: api/v1/Person/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Person>> GetPersonById(int id)
        {
            if (_personService.PersonExists(id) == false) return NotFound();

            var person = await _personService.FindById(id);

            return person;
        }

        // PUT METHOD: api/v1/Person/5
        [HttpPut("{id}")]
        public IActionResult PutPerson(int id, Person person)
        {
            if (id != person.Id) return BadRequest();

            _personService.Update(person);

            return NoContent();
        }

        // POST METHOD: api/v1/Person
        [HttpPost]
        public ActionResult<Person> PostPerson(Person person)
        {
            _personService.CreatePerson(person);
            return CreatedAtAction(nameof(GetPersonById), new { id = person.Id }, person);
        }

        // DELETE METHOD: api/v1/Person/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePerson(int id)
        {
            if (_personService.PersonExists(id) == false) return NotFound();

            var person = await _personService.FindById(id);
            _personService.Delete(id);

            return NoContent();
        }

    }
}

