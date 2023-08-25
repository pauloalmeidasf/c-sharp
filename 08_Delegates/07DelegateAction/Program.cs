/*
 * Delegate Action<T>
 * 
 * Delegate predefinido na linguagem C#
 * 
 * Representa um método que pode receber atá 16 argumentos de entrada e não retorna nenhuma valor
 * 
 * Assinatura: public delegate void Action<in T>(T obj)
 * 
 * Referência: https://learn.microsoft.com/pt-br/dotnet/api/system.action-1?view=net-7.0
 * 
 */

Console.WriteLine("Delegate Action<T>");
Console.WriteLine();

double raio = 2.5;

double altura = 4.2;

//Delegate Action<T> não retorna valor
Action<double> cubo = x => Console.WriteLine($"{raio} ao cubo: {Math.Pow(raio,3)}");

cubo(raio);

Console.WriteLine();

Action<double, double> quadrado = (x, y) => 
    Console.WriteLine($"{raio} ao cubo: {Math.Pow(raio, 3)} e {altura} ao quadrado: {Math.Pow(altura,2)}");

quadrado(raio, altura);

Console.WriteLine();

Console.Write("Pressione qualquer tecla para finalizar...");

Console.ReadKey();