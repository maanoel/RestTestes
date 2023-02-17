using Microsoft.AspNetCore.Mvc;
using TESTESRest.Services;

namespace TESTESRest.Controllers
{

    /* Não utilizar o route tinha levado a um cenário de conflitos de rotas
     * Os métodos get não eram chamados corretamente.
     * Isso fez com que sempre o método get(int id) fosse chamado, mesmo sem passar id na 
     */
    [ApiVersion("1")]
    [ApiController]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class PersonController : Controller
    {
        private IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        public IActionResult Get()
        {
            return Ok(_personService.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var person = _personService.FindById(id);

            if (person == null) return NotFound();

            return Ok(_personService.FindById(id));
        }

        [HttpPost]
        public IActionResult Post([FromBody] Person person)
        {
            if (person == null) return BadRequest();

            return Ok(_personService.Create(person));
        }

        [HttpPatch]
        public IActionResult Patch([FromBody] Person person)
        {
            if (person == null) return BadRequest();

            return Ok(_personService.Update(person));
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _personService.Delete(id);
            return NoContent();
        }
    }
}
