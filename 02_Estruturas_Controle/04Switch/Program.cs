/*
 * switch
 * 
 * Seleciona uma lista de instruções a ser executada com base em uma correspondência de padrão
 * 
 * Referência: https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/statements/selection-statements#the-switch-statement
 * 
 */

using System.Net.WebSockets;

Console.WriteLine("Estrutura switch");
Console.WriteLine();

Console.Write($"Valor da compra: ");
var valor = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine();

Console.Write("Quantidade de parcelas (1 a 4): ");
var parcelas = Convert.ToInt32(Console.ReadLine());

switch(parcelas)
{
    case 1:
        Console.WriteLine($"Valor parcelas: {valor/parcelas}");
        break;
    case 2:
        Console.WriteLine($"Valor parcelas: {valor / parcelas}");
        break;
    case 3:
        Console.WriteLine($"Valor parcelas: {valor / parcelas}");
        break;
    case 4:
        Console.WriteLine($"Valor parcelas: {valor / parcelas}");
        break;
    default:
        Console.WriteLine("Quantidade de parcelas inválida");
        break;
}

Console.WriteLine();

Console.WriteLine("Pressione qualquer tecla para finalizar...");

Console.ReadKey();