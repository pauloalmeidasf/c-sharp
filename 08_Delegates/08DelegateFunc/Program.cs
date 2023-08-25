/*
 * Delegate Func<T,TRresult>
 * 
 * Delegate predefinido na linguagem C#
 * 
 * Representa um método que pode receber até 16 argumentos de entrada e retorna um valor do tipo TResult
 * 
 * Assinatura: public delegate TResult Func<in T,out TResult>(T arg);
 * 
 * Referêcia: https://learn.microsoft.com/pt-br/dotnet/api/system.func-1?view=net-7.0
 * 
 */

Console.WriteLine("Delegate Fun<T>");
Console.WriteLine();

var numero = 765;

//utilizado quando for necessário referenciar um método que recebe vários argumentos e retorna um valor
Func<double, double> calculo = x => Math.Sqrt(x);

var resultado = calculo(numero);

Console.WriteLine($"Raiz quadrada de {numero}: {resultado}");

Console.WriteLine();

Console.Write("Pressione qualquer tecla para finalizar...");

Console.ReadKey();