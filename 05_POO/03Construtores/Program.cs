/*
 * Herança - Construtores
 * 
 * A classe derivada não herda o construtor da classe base; no entanto, a classe derivada poderá invocá-lo
 * 
 */

using Classes;

Console.WriteLine("Herança - Construtores");
Console.WriteLine();

var aluno1 = new Aluno();

Console.WriteLine();

var aluno2 = new Aluno("Helena");

Console.WriteLine();

Console.Write("Pressione qualquer tecla para finalizar...");

Console.ReadKey();