/*
 * Constantes
 * 
 * Não podem ser modificadas
 * 
 * Usa-se a palavra chave const para declarar uma constante
 * 
 * Referência: https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/const
 * 
 */

Console.WriteLine("Constantes");
Console.WriteLine();

//declarar e inicializar constantes

const int ANO = 2025;
const string SERVIDOR = "192.168.241.25";
const double PI = Math.PI;

Console.WriteLine($"Valor de PI: {PI}");
Console.WriteLine();

Console.WriteLine("Pressione qualquer tecla para finalizar...");
Console.ReadKey();