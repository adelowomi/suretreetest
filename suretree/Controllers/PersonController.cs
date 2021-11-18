using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using suretree.Interfaces;
using suretree.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace suretree.Controllers
{
    public class PersonController : Controller
    {
        private readonly IPerson _personService;
        public PersonController(IPerson person)
        {
            _personService = person;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("person/{id}", Name = nameof(GetUserById))]
        public ActionResult<Person> GetUserById(int Id)
        {
            return Ok(_personService.GetById(Id));
        }

        [HttpPost("person", Name = nameof(CreatePerson))]
        [ProducesResponseType(200)]
        public ActionResult<Person> CreatePerson([FromBody]Person person)
        {
            return Ok(_personService.Insert(person));
        }

        [HttpGet("persons", Name = nameof(ListPersons))]
        [ProducesResponseType(200)]
        public ActionResult ListPersons()
        {
            return Ok(_personService.List());
        }
    }
}

