using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

[ApiController]
[Route("users")]
public class UsersController : ControllerBase
{
    private static List<User> users = new List<User>();

    [HttpGet]
    public ActionResult<List<User>> GetUsers()
    {
        return Ok(users);
    }

    [HttpPost]
    public ActionResult<User> CreateUser([FromBody] User user)
    {
        users.Add(user);
        return CreatedAtAction(nameof(GetUser), new { userId = user.Id }, user);
    }

    [HttpGet("{userId}")]
    public ActionResult<User> GetUser(int userId)
    {
        var user = users.FirstOrDefault(u => u.Id == userId);
        if (user == null) return NotFound();
        return Ok(user);
    }

    [HttpPut("{userId}")]
    public ActionResult<User> UpdateUser(int userId, [FromBody] User updatedUser)
    {
        var user = users.FirstOrDefault(u => u.Id == userId);
        if (user == null) return NotFound();
        user.Name = updatedUser.Name;
        // Atualizar outros campos conforme necessário
        return Ok(user);
    }

    [HttpDelete("{userId}")]
    public IActionResult DeleteUser(int userId)
    {
        var user = users.FirstOrDefault(u => u.Id == userId);
        if (user == null) return NotFound();
        users.Remove(user);
        return NoContent();
    }

    [HttpGet("{userId}/orders")]
    public ActionResult<List<Order>> GetOrders(int userId)
    {
        // Supondo que temos um método para obter pedidos de um usuário
        var orders = GetOrdersForUser(userId);
        return Ok(orders);
    }

    [HttpPost("{userId}/orders")]
    public ActionResult<Order> CreateOrder(int userId, [FromBody] Order order)
    {
        // Adiciona o pedido ao usuário
        AddOrderToUser(userId, order);
        return CreatedAtAction(nameof(GetOrders), new { userId }, order);
    }

    private List<Order> GetOrdersForUser(int userId)
    {
        // Função simulada para obter pedidos
        return new List<Order>();
    }

    private void AddOrderToUser(int userId, Order order)
    {
        // Função simulada para adicionar pedido
    }
}

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    // Outros campos
}

public class Order
{
    public int Id { get; set; }
    public string Description { get; set; }
    // Outros campos
}
