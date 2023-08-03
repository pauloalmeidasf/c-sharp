/*
 * Precedência de operadores
 * 
 * Operadores Aritméticos: *,/,%,+,-
 * 
 * Referência 01: https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/operators/#operator-precedence
 * 
 * Referência 02: https://learn.microsoft.com/pt-br/office/vba/language/reference/user-interface-help/operator-precedence
 * 
 * Parênteses () podem ser utilizados para alterar a ordem de precedência
 * 
 */

Console.WriteLine("Precedência de Operadores");
Console.WriteLine();

double calculo = 10 - 2 * 3;

Console.WriteLine($"Valor do cálculo: {calculo}");
Console.WriteLine();

calculo = (10 - 2) * 3;

Console.WriteLine($"Valor do cálculo: {calculo}");
Console.WriteLine();

calculo = 4.0 / 2.0 * 3.0; //será resolvido da esquerda para a direita

Console.WriteLine($"Valor do cálculo: {calculo}");
Console.WriteLine();

calculo = 4.0 * 2.0 / 3.0; //será resolvido da esquerda para a direita

Console.WriteLine($"Valor do cálculo: {calculo}");
Console.WriteLine();

Console.WriteLine("Pressione qualquer tecla para finalizar....");

Console.ReadKey();
