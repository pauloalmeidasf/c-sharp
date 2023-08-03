/*
 * Operadores incrementais e decrementais
 * 
 * Aumentam ou diminuem em 1 unidade o valor de uma variável
 * 
 * Pós Incremento: x++
 * Pré Incremento: ++x
 * 
 * Pós Decremento: x--
 * Pré Decremento: --x
 * 
 * Referência: https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/operators/arithmetic-operators
 * 
 */

Console.WriteLine("Operadores de Incremento e Decremento");
Console.WriteLine();

//pós incremento: primeiro resolve, depois incrementa
Console.WriteLine("Pós Incremento");
Console.WriteLine();

int x = 5;

Console.WriteLine($"Valor de x: {x}");
Console.WriteLine($"Valor de x pós incremento: {x++}");
Console.WriteLine($"Valor de x: {x}");
Console.WriteLine();

//pré incremento: primerio incrementa, depois resolve
Console.WriteLine("Pré Incremento");
Console.WriteLine();

int y = 5;

Console.WriteLine($"Valor de y: {y}");
Console.WriteLine($"Valor de y pré incremento: {++y}");
Console.WriteLine($"Valor de y: {y}");
Console.WriteLine();

//pós decremento: primeiro resolve, depois decrementa
Console.WriteLine("Pós Decremento");
Console.WriteLine();

int z = 5;

Console.WriteLine($"Valor de z: {z}");
Console.WriteLine($"Valor de z pós decremento: {z--}");
Console.WriteLine($"Valor de z: {z}");
Console.WriteLine();

//pré decremento: primeiro decrementa, depois resolve
Console.WriteLine("Pré Decremento");
Console.WriteLine();

int w = 5;

Console.WriteLine($"Valor de w: {w}");
Console.WriteLine($"Valor de w pré decremento: {--w}");
Console.WriteLine($"Valor de w: {w}");
Console.WriteLine();

Console.WriteLine("Pressione qualquer tecla para finalizar...");

Console.ReadKey();