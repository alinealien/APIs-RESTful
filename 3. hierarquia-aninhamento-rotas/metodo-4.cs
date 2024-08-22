
using Microsoft.AspNetCore.Mvc;

namespace ApiExample.Controllers
{
    [ApiController]
    [Route("api/users/{userId}/orders")]
    public class OrdersController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetOrders(int userId)
        {
            // Lógica para buscar os pedidos do usuário
            return Ok($"Pedidos do usuário {userId}");
        }
    }
}
