/*
 * Object é a classe base de todas as classes .NET
 * 
 * Alguns métodos da classe Object:
 * 
 * Equals
 * GetHashCode
 * ToString
 * GetType
 * 
 * Referência: https://learn.microsoft.com/pt-br/dotnet/api/system.object?view=net-7.0
 * 
 */

using Classes;

Console.WriteLine("Classe Object");
Console.WriteLine();

var teste = new Teste();

Console.WriteLine($"Hash Code da classe Teste: {teste.GetHashCode()}");

Console.WriteLine();

Console.Write("Pressione qualquer tecla para finalizar...");

Console.ReadKey();