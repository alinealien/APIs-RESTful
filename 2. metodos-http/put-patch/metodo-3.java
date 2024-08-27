HttpClient client = HttpClient.newHttpClient();
HttpRequest request = HttpRequest.newBuilder()
    .uri(URI.create("https://api.exemplo.com/usuarios/1"))
    .header("Content-Type", "application/json")
    .method("PATCH", HttpRequest.BodyPublishers.ofString("{\"idade\":31}"))
    .build();

HttpResponse<String> response = client.send(request, HttpResponse.BodyHandlers.ofString());
System.out.println(response.body());
