/*
 * Exercícios sobre Delegates
 * 
 */

using Classes;

Console.WriteLine("Delegates - Exemplos Práticos");
Console.WriteLine();

var lista = Pessoa.Buscar();

//lista de pessoas
Console.WriteLine("Lista de pessoas");
Console.WriteLine();

lista.ForEach(p => Console.WriteLine($"Nome: {p.Nome}, Idade: {p.Idade}"));
Console.WriteLine();

//lista de pessoas maiores de idade
Console.WriteLine("Lista de pessoas - Maiores de Idade");
Console.WriteLine();

var adultos = lista.FindAll(p => p.Idade >= 18);

adultos.ForEach(v => Console.WriteLine($"Nome: {v.Nome}"));

Console.WriteLine();

//localiza a pessoa com a maior idade

//var maiorIdade = lista.Find(p => p.Idade == lista.Max(i => i.Idade));
var maiorIdade = lista.MaxBy(p => p.Idade);

Console.WriteLine($"Nome da pessoa mais velha da lista: {maiorIdade?.Nome}");
Console.WriteLine();

Console.Write("Pressione qualquer tecla para finalizar...");

Console.ReadKey();