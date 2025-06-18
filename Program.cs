using System;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;

class Program
{

    // Define a URL base do ViaCEP
    private static readonly string baseUrl = "https://viacep.com.br/ws/";

    // Executar projeto
    static async Task Main(string[] args)
    {
        Console.WriteLine("Digite o CEP para consulta:");
        string cep = Console.ReadLine();

        // Chama a função para consultar o CEP
        await ConsultarCepAsync(cep);
    }

    // Função para consultar o endereço usando o CEP
    public static async Task ConsultarCepAsync(string cep)
    {
        try
        {
            // Cria o cliente HTTP
            using (HttpClient client = new HttpClient())
            {
                // Faz a requisição GET
                HttpResponseMessage response = await client.GetAsync(baseUrl + cep + "/json/");
                response.EnsureSuccessStatusCode(); // Garante que o código de status da resposta é 200 OK

                // Lê a resposta como uma string
                string responseBody = await response.Content.ReadAsStringAsync();

                // Desserializa a resposta JSON para um objeto
                var endereco = JsonConvert.DeserializeObject<Endereco>(responseBody);

                // Exibe o resultado
                if (endereco != null && endereco.Erro == null)
                {
                    Console.WriteLine($"CEP: {endereco.Cep}");
                    Console.WriteLine($"Logradouro: {endereco.Logradouro}");
                    Console.WriteLine($"Complemento: {endereco.Complemento}");
                    Console.WriteLine($"Bairro: {endereco.Bairro}");
                    Console.WriteLine($"Cidade: {endereco.Localidade}");
                    Console.WriteLine($"Estado: {endereco.Uf}");
                }
                else
                {
                    Console.WriteLine("CEP não encontrado ou inválido.");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao consultar o CEP: {ex.Message}");
        }
    }
    
}
