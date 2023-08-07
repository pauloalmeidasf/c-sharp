/*
 * Loop Do While
 * 
 * Executa uma instruçào ou um bloco de instruções enquanto uma expressão booleana é avaliada como true
 * 
 * Como essa expressão é avaliada após cada execução do loop, um loop "do-while" será executado uma ou mais vezes
 * 
 * Referência: https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/statements/iteration-statements#the-do-statement
 * 
 */

Console.WriteLine("Loop do while");
Console.WriteLine();

var i = 1;

//while (i >= 50)
//{
//    Console.WriteLine($"Valor de i (while): {i}");

//    i++;

//}

do
{

    Console.WriteLine($"Valor de i: {i}");

    i++;

} while (i <= 10);

Console.WriteLine();

Console.Write("Pressione qualquer tecla para finalizar...");

Console.ReadKey();