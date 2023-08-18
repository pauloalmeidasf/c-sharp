/*
 * Interfaces
 * 
 * Cotêm definições para um grupo de funcionalidades relacionadas que uma classe ou uma estrutura podem implementar
 * 
 * Não podem ser instanciadas
 * 
 * Podem conter membros abstratos
 * 
 * Podem conter implementação (a partir da versão 8 do C#)
 * 
 * A classe que implementa a interface deve implementar os métodos abstratos desta interface
 * 
 * Uma classe pode implementar mais de uma interface
 * 
 * Referência: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/interface
 * 
 */

using Interfaces;
using Classes;

IForma forma = new Forma();

forma.Nome = "Triângulo";

Console.WriteLine($"{forma.Imprimir()}");
Console.WriteLine();

IControle? controle = forma as Forma;

controle?.Colorir();
controle?.Plotar();

Console.WriteLine();

Console.Write("Pressione qualquer tecla para finalizar...");

Console.ReadKey();