/*
 * 
 * Tipos Anônimos
 * 
 * Os tipos anônimos fornecem um modo conveniente de encapsular um conjunto de propriedades somente leitura
 * em um único objeto sem a necessidade de definir explicitamente um tipo (classe)
 * 
 * Referência: https://learn.microsoft.com/pt-br/dotnet/csharp/fundamentals/types/anonymous-types
 * 
 */

Console.WriteLine("Tipos anônimos");
Console.WriteLine();

var cliente = new
{

    Nome = "Ricardo",
    CPF = "98765432100",
    Endereco = new { 
        Logradouro = "Rua 7 de Setembro, 100", Bairro = "Indendência", Cidade = "São Vicente", Estado = "SP"
    }

};

Console.WriteLine($"Nome: {cliente.Nome}\nCPF: {cliente.CPF}\nEndereço: {cliente.Endereco.Logradouro}");
Console.WriteLine();

Console.Write("Pressione qualquer tecla para finalizar...");

Console.ReadKey();