@RestController
@RequestMapping("/v1/users")
public class UserControllerV1 {

    @GetMapping
    public List<User> getUsersV1() {
        return List.of(new User(1, "John Doe v1"));
    }
}

@RestController
@RequestMapping("/v2/users")
public class UserControllerV2 {

    @GetMapping
    public List<User> getUsersV2() {
        return List.of(new User(1, "John Doe v2", "john@example.com"));
    }
}
