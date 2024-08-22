@RestController
@RequestMapping("/users")
public class UserController {

    @PostMapping
    public ResponseEntity<String> createUser(@RequestBody User user) {
        // Lógica para criar o usuário
        return new ResponseEntity<>("Usuário criado com sucesso!", HttpStatus.CREATED);
    }
}
