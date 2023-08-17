/*
 * Conversão de tipo em tempo de execução
 * 
 * Referência: https://learn.microsoft.com/pt-br/dotnet/csharp/programming-guide/types/casting-and-type-conversions#see-also
 * 
 */

using Classes;

Console.WriteLine("Upcasting de Downcasting");
Console.WriteLine();

Circulo circulo = new Circulo(10, 30);

Console.WriteLine("upcasting");
Console.WriteLine();

//upcasting (ímplicito)
Forma forma = circulo;

forma.Desenhar();

Console.WriteLine();

Console.WriteLine("downcasting");
Console.WriteLine();

//downcasting (explícito): poderá ocorrer erro de exceção se o casting não for possível
Circulo c = (Circulo)forma;

c.Colorir();
c.Desenhar();

Console.WriteLine();

Console.ReadKey();