using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        using (HttpClient client = new HttpClient())
        {
            var atualizacaoUsuario = new StringContent(
                "{\"idade\":31}",
                Encoding.UTF8,
                "application/json");

            var request = new HttpRequestMessage(new HttpMethod("PATCH"), "https://api.exemplo.com/usuarios/1")
            {
                Content = atualizacaoUsuario
            };

            HttpResponseMessage response = await client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();
                Console.WriteLine(data);
            }
        }
    }
}
