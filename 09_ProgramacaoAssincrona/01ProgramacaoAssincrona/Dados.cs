namespace Classes;

internal class Dados
{

    //Declara método assíncrono sem retorno
    public static async Task ObterDadosAsync()
    {

        var cliente = new HttpClient();

        var leitura = cliente.GetStringAsync("https://learn.microsoft.com/pt-br/dotnet/csharp/asynchronous-programming/");

        Mensagem();

        var texto = await leitura;

        Console.WriteLine(texto);

    }

    public static async Task<int> ObterTotalCaracteresAsync()
    {

        var cliente = new HttpClient();

        var leitura = cliente.GetStringAsync("https://learn.microsoft.com/pt-br/dotnet/csharp/asynchronous-programming/");

        Mensagem();

        var texto = await leitura;

        return texto.Length;

    }

    private static void Mensagem()
    {

        Console.WriteLine("Buscando dados...");
        Console.WriteLine();

    }
}
