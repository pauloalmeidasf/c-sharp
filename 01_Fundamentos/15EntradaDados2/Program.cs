/*
 * Entrada de Dados
 * 
 * CultureInfo: https://learn.microsoft.com/pt-br/dotnet/api/system.globalization.cultureinfo?view=net-7.0
 * Formato Numérico Padrão: https://learn.microsoft.com/pt-br/dotnet/standard/base-types/standard-numeric-format-strings
 * 
 */

using System.Globalization;

Console.WriteLine("Entrada de dados");
Console.WriteLine();

Console.Write("Informe o nome do colaborador: ");
string? nome = Console.ReadLine();

Console.Write("Data Admissão: ");
DateTime admissao = Convert.ToDateTime(Console.ReadLine());

Console.Write("Salário: ");
decimal salario = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("Dados informados - Cultura Local");
Console.WriteLine();

Console.WriteLine($"Nome: {nome}");
Console.WriteLine($"Admissão: {admissao:d}");
Console.WriteLine($"Salário: {salario:c}");
Console.WriteLine();

Console.WriteLine("Dados informados - Inglês (Estados Unidos)");
Console.WriteLine();

CultureInfo inglesUS = new CultureInfo("en-US");

Console.WriteLine($"Nome: {nome}");
Console.WriteLine($"Admissão: {admissao.ToString("d", inglesUS)}");
Console.WriteLine($"Salário: {salario.ToString("c", inglesUS)}");
Console.WriteLine();

Console.WriteLine("Pressione qualquer tecla para continuar...");

Console.ReadKey();