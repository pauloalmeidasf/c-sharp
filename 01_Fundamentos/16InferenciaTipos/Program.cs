/*
 * Inferência de tipos (var)
 * 
 * O compilador irá inferir o tipo da variável a partir da expressão de inicialização
 * 
 * Referência: https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/statements/declarations
 * 
 */

Console.WriteLine("Inferência de Tipos");
Console.WriteLine();

var idade = 25;
var nome = "Marcos";
var salario = 12900.95m;
var cargo = "";
var ativo = true;

Console.WriteLine($"{nome} tem {idade} anos e seu salário é {salario:c}");
Console.WriteLine();

//limitações

//var nomeColaborador = null;
//var ativo;
//var a = 10, b = 1, c = 15;

var soma = 0;
soma = soma + 500;

Console.WriteLine("Pressione qualquer tecla para continuar...");

Console.ReadKey();