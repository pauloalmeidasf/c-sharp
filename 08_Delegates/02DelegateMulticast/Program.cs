/*
 * Multicast Delegate
 * 
 * Útil quando várias ações precisam ser executadas quando ocorrer um evento
 * 
 * Referência 01: https://learn.microsoft.com/pt-br/dotnet/api/system.multicastdelegate?view=net-7.0
 * 
 * Referência 02: https://learn.microsoft.com/pt-br/dotnet/csharp/programming-guide/delegates/how-to-combine-delegates-multicast-delegates
 * 
 */

using Maquinas;
using Controles;

var dobradura = new MaquinaDobradura();
var modelagem = new MaquinaModelagem();
var pintura = new MaquinaPintura();
var solda = new MaquinaSolda();

Console.WriteLine("Estado das máquinas antes de usar o delegate para desligá-las");
Console.WriteLine();

Console.WriteLine($"Máquina Dobradura Ligada: {dobradura.Ligada}");
Console.WriteLine($"Máquina Modelagem Ligada: {modelagem.Ligada}");
Console.WriteLine($"Máquina Pintura Ligada: {pintura.Ligada}");
Console.WriteLine($"Máquina Solda Ligada: {solda.Ligada}");

Console.WriteLine();

Controle.Adiciona(dobradura.Desligar);
Controle.Adiciona(modelagem.Desligar);
Controle.Adiciona(pintura.Desligar);
Controle.Adiciona(solda.Desligar);

//Criar condição para uma regra de negócio
Controle.Remove(dobradura.Desligar);

Controle.Desligar();

Console.WriteLine("Estado das máquinas após usar o delegate para desligá-las");
Console.WriteLine();

Console.WriteLine($"Máquina Dobradura Ligada: {dobradura.Ligada}");
Console.WriteLine($"Máquina Modelagem Ligada: {modelagem.Ligada}");
Console.WriteLine($"Máquina Pintura Ligada: {pintura.Ligada}");
Console.WriteLine($"Máquina Solda Ligada: {solda.Ligada}");

Console.WriteLine();

Console.Write("Pressione qualquer tecla para finalizar...");

Console.ReadKey();