using Microsoft.AspNetCore.Mvc;

namespace ExampleApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ResourceController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetResource()
        {
            // Simula uma verificação para recurso
            string resource = null; // Suponha que o recurso não foi encontrado

            if (resource != null)
            {
                return Ok(resource); // Retorna 200 OK
            }
            else
            {
                return NotFound("Recurso não encontrado"); // Retorna 404 Not Found
            }
        }

        [HttpGet("bad-request")]
        public IActionResult BadRequestExample()
        {
            // Simula uma requisição inválida
            return BadRequest("Requisição inválida"); // Retorna 400 Bad Request
        }
    }
}
