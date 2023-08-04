/*
 * If
 * 
 * Referência: https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/statements/selection-statements#the-if-statement
 * 
 */

Console.WriteLine("Instrução If");
Console.WriteLine();

Console.Write("Cliente Premium? (S ou N): ");
var resposta = Console.ReadLine()?.ToUpper();

if(resposta == "S")
{
    Console.WriteLine($"O cliente possui 5% de desconto");
}
    
Console.WriteLine();

var x = 30;
var y = 45;

if (x > y == true) //== true pode ser omitido
{
    Console.WriteLine($"{x} é maior que {y}");
}

if(x < y)
{
    Console.WriteLine($"{x} é menor que {y}");
}

if (x == y)
{
    Console.WriteLine($"{x} é igual que {y}");
}

Console.WriteLine();

Console.WriteLine("Pressione qualquer tecla para finalizar...");

Console.ReadKey();