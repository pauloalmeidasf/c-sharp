/*
 * Referências Anuláveis
 * 
 * Referência: https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/builtin-types/nullable-value-types
 * 
 */

Console.WriteLine("Referências Anuláveis");
Console.WriteLine();

string? curso = "JAVASCRIPT";

Console.WriteLine($"Curso: {curso?.ToLower()}");

Console.WriteLine();

Console.WriteLine("Pressione qualquer tecla para finalizar...");

Console.ReadKey();