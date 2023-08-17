/*
 * Modificador sealed
 * 
 * Quando aplicado em uma classe, o modificador sealed impede que outras classes herdem dela
 * 
 * É possível utilizar o modificador sealed em um método ou propriedade que substitui um método ou propriedade virtual
 * em uma classe. Desssa forma, será permitido que classes sejam derivadas da classe base e impede que substituam
 * métodos ou propriedades virtuais
 * 
 * Referência: https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/sealed
 * 
 */

using Classes;

Console.WriteLine("Modificador Sealed");
Console.WriteLine();

Console.WriteLine("Classe Base");
Console.WriteLine();

var b = new Base();

b.M1();
b.M2();

Console.WriteLine();

Console.WriteLine("Classe Derivada1");
Console.WriteLine();

var d1 = new Derivada1();

d1.M1();
d1.M2();

Console.WriteLine();

Console.WriteLine("Classe Derivada2");
Console.WriteLine();

var d2 = new Derivada2();

d2.M1();
d2.M2();

Console.WriteLine();

Console.Write("Pressione qualquer tecla para finalizar...");

Console.ReadKey();