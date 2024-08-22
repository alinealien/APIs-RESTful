using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MyApi.Controllers
{
    // Versão 1 da rota /users
    [ApiController]
    [Route("api/v1/[controller]")]
    public class UsersV1Controller : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<UserV1>> Get()
        {
            return new List<UserV1>
            {
                new UserV1 { Id = 1, Name = "John Doe v1" }
            };
        }
    }

    // Versão 2 da rota /users
    [ApiController]
    [Route("api/v2/[controller]")]
    public class UsersV2Controller : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<UserV2>> Get()
        {
            return new List<UserV2>
            {
                new UserV2 { Id = 1, 
                Name = "John Doe v2", 
                Email = "john@example.com" }
            };
        }
    }

    // Modelos de dados para cada versão
    public class UserV1
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class UserV2
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}

