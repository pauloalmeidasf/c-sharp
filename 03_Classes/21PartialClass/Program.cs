/*
 * Partial Class
 * 
 * É possível dividir a definição de uma classe, struct, interface ou método em 2 ou mais arquivos de origem
 * 
 * Cada arquivo contém uma seção da definição de tipo ou método e todas as partes são combinadas quando
 * a aplicação é compilada
 * 
 * Referência: https://learn.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/partial-classes-and-methods
 * 
 */

using Classes;

Console.WriteLine("Partial Class");
Console.WriteLine();

var pessoa = new Pessoa();

var nascimento = new DateTime(2003, 08, 10);

var idade = Math.Round(pessoa.CalcularIdade(nascimento).TotalDays/365,0);

Console.WriteLine($"Idade da pessoa: {idade}");
Console.WriteLine();

Console.Write("Pressione qualquer tecla para continuar...");

Console.ReadKey();