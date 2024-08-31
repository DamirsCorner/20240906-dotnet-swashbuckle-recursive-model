using Microsoft.AspNetCore.Mvc;
using OpenApiRecursiveModel.Models;

namespace OpenApiRecursiveModel.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PersonController : ControllerBase
{
    [HttpGet]
    public ActionResult<Person> Get()
    {
        var person = new Person("John", "Doe")
        {
            Children =
            [
                new Person("Jane", "Doe")
                {
                    Children = [new Person("Alice", "Doe"), new Person("Bob", "Doe"),]
                },
                new Person("Jack", "Doe"),
            ]
        };
        return Ok(person);
    }
}
