using System.Text.Json;

namespace Classes;

internal class Arquivo
{

    public static async Task SalvarJsonAsync(string arquivo, List<Clima> dados)
    {

        string jsonString = JsonSerializer.Serialize(dados);

        await File.WriteAllTextAsync(arquivo, jsonString);

    }

    public static async Task LerJsonAsync(string arquivo)
    {

        var leitura = File.ReadAllTextAsync(arquivo);

        var jsonString = await leitura;

        List<Clima>? lista = JsonSerializer.Deserialize<List<Clima>>(jsonString);

        foreach (var item in lista)
        {

            Console.WriteLine($"Data: {item.Data:d}. Cidade: {item.Cidade}. Temperatura: {item.Temperatura}");

        }

    }

    public static void ExcluirJson(string arquivo)
    {

        File.Delete(arquivo);

    }

}