/*
 * while
 * 
 * executa uma instrução ou bloco de instruções enquanto uma expressão booleana é avaliada como true
 * 
 * Referência: https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/statements/iteration-statements#the-while-statement
 * 
 */

Console.WriteLine("Loop while");
Console.WriteLine();

Console.WriteLine("Escreve os valores de 1 a 10");
Console.WriteLine();

var i = 1;

while(i <= 10)
{

    Console.WriteLine($"valor de i: {i}");

    i++;

}

Console.WriteLine();

Console.WriteLine("Escreve os valores de 1 a 10 (Decrescente)");
Console.WriteLine();

var j = 10;

while(j > 0)
{

    Console.WriteLine($"valor de j: {j}");
    j--;
}

Console.WriteLine();

Console.WriteLine("Pressione qualquer tecla para finalizar...");

Console.ReadKey();