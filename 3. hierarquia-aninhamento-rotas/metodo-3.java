import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class OrderController {

    @GetMapping("/users/{userId}/orders")
    public String getOrders(@PathVariable String userId) {
        // Lógica para buscar os pedidos do usuário
        return "Pedidos do usuário " + userId;
    }
}
