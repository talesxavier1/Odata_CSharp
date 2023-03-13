using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Odata.Models;
using Odata.Repository.Implementations;
namespace Odata.Controllers;

public class PersonController2 : ODataController {
    //[EnableQuery]
    public IActionResult Post([FromBody] int doisao) {
        PersonRepository personRepository = new();
        List<PersonModel> personModels = personRepository.getPersons(100);
        return Ok(personModels);
    }
}
