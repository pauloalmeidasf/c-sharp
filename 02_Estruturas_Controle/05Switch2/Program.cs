/*
 * switch
 * 
 * Seleciona uma lista de instruções a ser executada com base em uma correspondência de padrão
 * 
 * Referência: https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/statements/selection-statements#the-switch-statement
 * 
 */

Console.WriteLine("Estrutura switch");
Console.WriteLine();

Console.Write("Informe o mês: ");
var mes = Console.ReadLine()?.ToLower();

switch (mes)
{
    case "janeiro":
    case "março":
    case "maio":
    case "julho":
    case "agosto":
    case "outubro":
    case "dezembro":
        Console.WriteLine($"{mes} tem 31 dias");
        break;
    case "fevereiro":
        Console.WriteLine($"{mes} tem 28 ou 29 dias");
        break;
    case "abril":
    case "junho":
    case "setembro":
    case "novembro":
        Console.WriteLine($"{mes} tem 30 dias");
        break;
    default:
        Console.WriteLine($"Mês inválido");
        break;
}

Console.WriteLine();

Console.WriteLine("Pressione qualquer tecla para finalizar...");

Console.ReadKey();