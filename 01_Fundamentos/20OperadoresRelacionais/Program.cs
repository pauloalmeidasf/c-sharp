/*
 * Operadores Relacionais
 * 
 * == : igualdade
 * >   : maior que
 * <   : menor que
 * >= : maior ou igual
 * <= : menor ou igual
 * !=  : diferente
 * 
 * Obeject.Equals: determina se 2 objetos são iguais
 * 
 * O resultado de uma operação relacional é TRUE ou FALSE
 * 
 * Referência 01: https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/operators/
 * Referência 02: https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/operators/comparison-operators
 * Referência 03: https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/operators/equality-operators
 * 
 */

using System.Diagnostics.SymbolStore;

Console.WriteLine("Operadores Relacionais");
Console.WriteLine();

int a = 15;
int b = 25;
bool comparacao = a == b;

Console.WriteLine($"Resultado da comparação de igualdade: {comparacao}");
Console.WriteLine();

int x = 10;
double y = 10;

//operadores relacionais com tipo-valor
Console.WriteLine($"o valor de x é igual ao valor de y: {x == y}");
Console.WriteLine($"o objeto x é igual ao objeto y: {x.Equals(y)}");
Console.WriteLine($"o valor de x é maior que o valor de y: {x > y}");
Console.WriteLine($"o valor de x é menor que o valor de y: {x < y}");
Console.WriteLine($"o valor de x é maior ou igual ao valor de y: {x >= y}");
Console.WriteLine($"o valor de x é menor ou igual ao valor de y: {x <= y}");
Console.WriteLine($"o valor de x é diferente do valor de y: {x != y}");
Console.WriteLine();

//operadores relacionais com tipo-referência

string curso = "Curso de CSharp";
string cursoAtualizado = "curso de csharp";

Console.WriteLine($"A variável 'curso' é igual à variável 'cursoAtualizado (==)': {curso == cursoAtualizado}");
Console.WriteLine($"A variável 'curso' é igual à variável 'cursoAtualizado' (Equals): {curso.Equals(cursoAtualizado)}");
Console.WriteLine();

Console.WriteLine("Pressione qualquer tecla para finalizar...");

Console.ReadKey();
