/*
 * 
 * Bloco try-catch, try-finally, try-catch-finally
 * 
 * Uma exceção é um erro que ocorre em tempo de execução
 * 
 * Se o código não fornecer um mecanismo para tratar a exceção, o sistema vai parar a execução
 * 
 * Referência: https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/statements/exception-handling-statements
 * 
 */

Console.WriteLine("Bloco try-catch");
Console.WriteLine();

int x = 9;
double y = 0;

try
{

    double z = x / y;

    Console.WriteLine($"Divisão entre {x} e {y}: {z}");
    Console.WriteLine();

}
catch (Exception e)
{

    Console.WriteLine("Não é possível realizar a divisão por 0 ...");
    Console.WriteLine();

    Console.WriteLine($"Informações da exceção: {e.StackTrace}");
    Console.WriteLine();

    Console.WriteLine($"Informações da exceção: {e.Message}");
    Console.WriteLine();

}

Console.Write("Pressione qualquer tecla para finalizar...");

Console.ReadKey();