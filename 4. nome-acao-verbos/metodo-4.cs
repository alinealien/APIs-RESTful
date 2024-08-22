using Microsoft.AspNetCore.Mvc;

namespace ApiExample.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        // POST: api/users
        [HttpPost]
        public IActionResult CreateUser([FromBody] User newUser)
        {
            // Lógica para criar o usuário
            return StatusCode(201, newUser);
        }
    }

    // Classe de exemplo para representar um usuário
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
