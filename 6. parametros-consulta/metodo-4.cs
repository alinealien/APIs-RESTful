using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        // Cria uma instância do HttpClient
        using (HttpClient client = new HttpClient())
        {
            // Define a URL base
            string baseUrl = "https://example.com/products";

            // Cria a string dos parâmetros de consulta
            string queryString = "category=electronics&limit=10&page=1&sort=price";

            // Concatena a URL base com a string dos parâmetros de consulta
            string requestUrl = $"{baseUrl}?{queryString}";

            // Faz a solicitação GET
            HttpResponseMessage response = await client.GetAsync(requestUrl);

            // Verifica se a resposta foi bem-sucedida
            if (response.IsSuccessStatusCode)
            {
                // Lê o conteúdo da resposta
                string responseBody = await response.Content.ReadAsStringAsync();

                // Exibe o conteúdo da resposta
                Console.WriteLine(responseBody);
            }
            else
            {
                // Exibe uma mensagem de erro se a solicitação falhar
                Console.WriteLine($"Erro: {response.StatusCode}");
            }
        }
    }
}
