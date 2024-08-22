using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ExampleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        // Rota correta com substantivo plural
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetUsers()
        {
            var users = new List<string> { "User1", "User2", "User3" };
            return Ok(users);
        }

        // Rota incorreta com verbo
        [HttpGet("/getAllUsers")]
        public ActionResult<IEnumerable<string>> RetrieveAllUsers()
        {
            var users = new List<string> { "User1", "User2", "User3" };
            return Ok(users);
        }
    }
}
