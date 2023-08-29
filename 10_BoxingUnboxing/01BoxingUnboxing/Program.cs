/*
 * 
 * Boxing e Unboxing
 * 
 * Referência: https://learn.microsoft.com/pt-br/dotnet/csharp/programming-guide/types/boxing-and-unboxing#unboxing
 * 
 */

Console.WriteLine("Boxing e Unboxing");
Console.WriteLine();

double nota = 10; //tipo-valor, armazenado na memória Stack

object notaBoxing = nota; //boxing: conversão de um tipo-valor para um tipo object (tipo-referÊncia)

double notaUnboxing = (double) notaBoxing; //unboxing: conversão de um tipo object (tipo-referência) para um tipo-valor

Console.ReadKey();