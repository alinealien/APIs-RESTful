import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class ProductController {

    // Rota correta com substantivo plural
    @GetMapping("/products")
    public String getAllProducts() {
        return "Listando todos os produtos";
    }

    // Rota incorreta com verbo
    @GetMapping("/getAllProducts")
    public String retrieveAllProducts() {
        return "Listando todos os produtos";
    }
}
