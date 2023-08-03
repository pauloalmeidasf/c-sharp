/*
 * Operadores unários: +, -
 * 
 */

Console.WriteLine("Operador Unário");
Console.WriteLine();

int valor = 25;

Console.WriteLine($"O valor positivo de {valor} é: {valor}"); //o operador + pode ser omitido
Console.WriteLine();

Console.WriteLine($"O valor negativo de {valor} é: {- valor}");
Console.WriteLine();

/*
 * Operador Ternário (?:)
 * 
 * Avalia uma expressão booleana e retorna o resultado de uma das duas expressões
 * 
 * Referência: https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/operators/conditional-operator
 * 
 */

Console.WriteLine("Operador Ternário");
Console.WriteLine();

var x = 15;
var y = 15;

string avaliacao = x % 2 == 0 ? $"O número {x} é par" : $"O número {x} é ímpar";

Console.WriteLine(avaliacao);

Console.WriteLine();

string teste = x > y ? $"{x} é maior que {y}" : x < y ? $"{x} é menor que {y}" : x == y ? $"{x} é igual a {y}" : "nda";

Console.WriteLine(teste);

Console.WriteLine();

Console.WriteLine("Pressione qualquer tecla para finalizar...");

Console.ReadKey();