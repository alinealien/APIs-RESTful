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
            var novoUsuario = new StringContent(
                "{\"nome\":\"João\",\"idade\":30}",
                Encoding.UTF8,
                "application/json");

            HttpResponseMessage response = await client.PostAsync("https://api.exemplo.com/usuarios", novoUsuario);
            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();
                Console.WriteLine(data);
            }
        }
    }
}
