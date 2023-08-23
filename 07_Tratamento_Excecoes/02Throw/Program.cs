/*
 * 
 * throw
 * 
 * Lança uma exceção
 * 
 * Referência: https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/statements/exception-handling-statements#the-throw-statement
 * 
 */

using Classes;
using System.Text;

Console.OutputEncoding = Encoding.Unicode;

Console.WriteLine("Lançamento de Exceções - throw");
Console.WriteLine();

try
{

    Console.Write("Informe o peso (kg): ");
    double peso = Convert.ToDouble(Console.ReadLine());

    Console.Write("Informe a altura (m): ");
    double altura = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine();

    Console.WriteLine($"IMC: {Calculo.CalculoIMC(peso, altura)}");
	Console.WriteLine();

}
catch (Exception e)
{
	Console.WriteLine();
	Console.WriteLine(e.Message);
	Console.WriteLine();
}

Console.WriteLine();

Console.WriteLine("Pressione qualquer tecla para finalizar...");

Console.ReadKey();