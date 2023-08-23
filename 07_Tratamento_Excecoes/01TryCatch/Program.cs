/*
 * 
 * Instruções de manipulação de exceção
 * 
 * try-catch, try-catch-finally
 * 
 * Capturar e tratrar exceções que podem ocorrer durante a execução de um bloco de código
 * 
 * Referência: https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/statements/exception-handling-statements
 * 
 */

using System.Text;

Console.OutputEncoding = Encoding.Unicode;

Console.WriteLine("Tratamento e Manipulação de Exceções");
Console.WriteLine();

try
{

    Console.Write("Digite o numerador: ");
    double numerador = Convert.ToDouble(Console.ReadLine());

    Console.Write("Digite o denominador: ");
    double denominador = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine();

    double resultado = numerador / denominador;

    Console.WriteLine($"{numerador} / {denominador}: {resultado}");
    Console.WriteLine();
   
}
catch (FormatException e)
{
    Console.WriteLine();
    Console.WriteLine(e.Message);
    Console.WriteLine(e.StackTrace);
    Console.WriteLine();
}
catch (OverflowException e)
{
    Console.WriteLine();
    Console.WriteLine(e.Message);
    Console.WriteLine();
}
catch (DivideByZeroException e)
{
    Console.WriteLine();
    Console.WriteLine(e.Message);
    Console.WriteLine();
}
catch (Exception e)
{
    Console.WriteLine();
    Console.WriteLine(e.Message);
    Console.WriteLine();
}
finally
{
    Console.WriteLine();
    Console.WriteLine("Processo finalizado...");
    Console.WriteLine();
}

Console.WriteLine();

Console.Write("Pressione qualquer tecla para finalizar...");

Console.ReadKey();