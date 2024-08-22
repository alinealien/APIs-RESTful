import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.web.bind.annotation.*;

import java.util.ArrayList;
import java.util.List;
import java.util.Optional;

@SpringBootApplication
public class UserApiApplication {

    public static void main(String[] args) {
        SpringApplication.run(UserApiApplication.class, args);
    }
}

@RestController
@RequestMapping("/users")
class UserController {

    private List<User> users = new ArrayList<>();

    @GetMapping
    public List<User> getUsers() {
        return users;
    }

    @PostMapping
    public User createUser(@RequestBody User user) {
        users.add(user);
        return user;
    }

    @GetMapping("/{userId}")
    public User getUser(@PathVariable int userId) {
        return users.stream()
                .filter(user -> user.getId() == userId)
                .findFirst()
                .orElse(null);
    }

    @PutMapping("/{userId}")
    public User updateUser(@PathVariable int userId, @RequestBody User updatedUser) {
        User user = users.stream()
                .filter(u -> u.getId() == userId)
                .findFirst()
                .orElse(null);
        if (user != null) {
            user.setName(updatedUser.getName());
            // Atualizar outros campos conforme necessário
        }
        return user;
    }

    @DeleteMapping("/{userId}")
    public void deleteUser(@PathVariable int userId) {
        users.removeIf(user -> user.getId() == userId);
    }

    @GetMapping("/{userId}/orders")
    public List<Order> getOrders(@PathVariable int userId) {
        // Supondo que temos um método para obter pedidos de um usuário
        return getOrdersForUser(userId);
    }

    @PostMapping("/{userId}/orders")
    public Order createOrder(@PathVariable int userId, @RequestBody Order order) {
        // Adiciona o pedido ao usuário
        addOrderToUser(userId, order);
        return order;
    }

    private List<Order> getOrdersForUser(int userId) {
        // Função simulada para obter pedidos
        return new ArrayList<>();
    }

    private void addOrderToUser(int userId, Order order) {
        // Função simulada para adicionar pedido
    }
}

class User {
    private int id;
    private String name;
    // Getters e setters
}

class Order {
    private int id;
    private String description;
    // Getters e setters
}
