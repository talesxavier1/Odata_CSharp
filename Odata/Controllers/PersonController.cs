using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Odata.Models;
using Odata.Repository.Implementations;
namespace Odata.Controllers;

[ApiController]
[Route("pessoa")]
public class PersonController : ControllerBase {

    [HttpGet]
    [Route("get")]
    [EnableQuery]
    public ActionResult<List<PersonModel>> Get([FromQuery] int page) {
        PersonRepository personRepository = new();
        List<PersonModel> personModels = personRepository.getPersons(page);
        return Ok(personModels);
    }
}
