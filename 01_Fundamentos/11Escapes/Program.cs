/*
 * Escapes
 * 
 * \n  : pula uma linha
 * \'   : aspas simples
 * \"  : aspas duplas
 * \\  : barra
 * 
 * Referência: https://learn.microsoft.com/pt-br/dotnet/csharp/programming-guide/strings/
 * 
 */

Console.WriteLine("Escapes");
Console.WriteLine();

//barra invertida

string arquivo = "c:\\dados\\localizacao.json";

Console.WriteLine("Barra invertida");
Console.WriteLine();

Console.WriteLine($"Local do arquivo: {arquivo}");
Console.WriteLine();

//aspas duplas

string informacaoCurso = "O curso de ASP.NET usa a \"linguagem\" CSharp";

Console.WriteLine("Aspas Duplas");
Console.WriteLine();

Console.WriteLine($"Informação do curso: {informacaoCurso}");
Console.WriteLine();

//nova linha

string nomeProduto = "\nMilk Shake de Morango";

Console.WriteLine("Nova Linha");
Console.WriteLine();

Console.WriteLine($"Nome do produto: {nomeProduto}");
Console.WriteLine();

Console.WriteLine("Pressione qualquer tecla para finalizar...");

Console.ReadKey();