/*
 * Delegate
 * 
 * É um tipo que representa referências aos métodos com lista de parâmetros e tipo de retorno definidos
 * 
 * Ao instanciar um delegate, é possível associar sua instância a qualquer método com assinatura e tipo de retorno
 * compatíveis
 * 
 * É possível chamar um método por meio da instância de delegate
 * 
 * Delegates são úteis para passar métodos como argurmentos a outros métodos
 * 
 * Referência 01: https://learn.microsoft.com/pt-br/dotnet/csharp/programming-guide/delegates/
 * 
 * Referência 02: https://learn.microsoft.com/pt-br/dotnet/csharp/programming-guide/delegates/using-delegates
 * 
 */

using Classes;
using Delegates;

Console.WriteLine("Delegates");
Console.WriteLine();

//atribui a referência do método Calculadora.Somar(double x, double y) ao delegate DelegateCalculadora
//var delSomar = new DelegateCaculadora(Calculadora.Somar);
DelegateCalculadora delSomar = Calculadora.Somar;

//var soma = delSomar.Invoke(21.95, 133.4);
var soma = delSomar(21.95,133.4);

Console.WriteLine($"Soma: {soma}");
Console.WriteLine();

DelegateCalculadora delMultiplicar = Calculadora.Multiplicar;

var multiplicacao = delMultiplicar(21.95, 133.4);

Console.WriteLine($"Multiplicação: {multiplicacao}");
Console.WriteLine();

DelegateCalculadora delegateCalc;

delegateCalc = Calculadora.Subtrair;

var subtracao = delegateCalc(21.95, 133.4);

Console.WriteLine($"Subtração: {subtracao}");
Console.WriteLine();

delegateCalc = Calculadora.Dividir;

var divisao = delegateCalc(21.95, 133.4);

Console.WriteLine($"Divisão: {divisao}");
Console.WriteLine();

Console.Write("Pressione qualquer tecla para finalizar...");

Console.ReadKey();