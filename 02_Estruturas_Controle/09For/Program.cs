/*
 * 
 * Loop for
 * 
 * Executa uma instrução ou um bloco de instruções enquanto uma expressão booleana é avaliada como true
 * 
 * Estrutura:
 * 
 * for(inicializador; condição; iterador){
 * 
 *      instrucao;
 *      
 * }
 * 
 * Referência: https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/statements/iteration-statements#the-for-statement
 * 
 */

Console.WriteLine("Loop for");
Console.WriteLine();

int numero = 7;
double resultado = 0;

for(var i = 1; i < 11; i++)
{

    resultado = numero * i;

    Console.WriteLine($"{numero} * {i}: {resultado}");

}

Console.WriteLine();

Console.WriteLine("Loop for - Multiplas inicializações");
Console.WriteLine();

for (int i = 0, j = 0; i + j <= 20; i++, j+=2) //j = j + 2 <=> j+=2
{

    Console.Write($"({i},{j}) ");

    Console.WriteLine();

}

Console.WriteLine("Pressione qualquer tecla para finalizar...");

Console.ReadKey();