using Microsoft.AspNetCore.Mvc;

namespace ExampleApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ResourcesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetResources()
        {
            // Simula uma verificação para recurso
            string resources = null; // Suponha que o recurso não foi encontrado

            if (resources != null)
            {
                return Ok(resources); // Retorna 200 OK
            }
            else
            {
                return NotFound(new ErrorResponse("Recurso não encontrado")); // Retorna 404 Not Found com uma resposta padronizada
            }
        }

        [HttpGet("bad-request")]
        public IActionResult BadRequestExample()
        {
            // Simula uma requisição inválida
            return BadRequest(new ErrorResponse("Requisição inválida")); // Retorna 400 Bad Request com uma resposta padronizada
        }
    }

    // Classe para padronizar a resposta de erro
    public class ErrorResponse
    {
        public string Message { get; set; }

        public ErrorResponse(string message)
        {
            Message = message;
        }
    }
}
