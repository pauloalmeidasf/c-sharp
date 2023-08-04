/*
 * if-else
 * 
 * Referência: https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/statements/selection-statements#the-if-statement
 * 
 */

Console.WriteLine("Instrução If-else");
Console.WriteLine();

Console.Write($"Informe a nota do aluno: ");
var nota = Convert.ToDouble(Console.ReadLine());

if(nota >= 7)
{
    Console.WriteLine($"Aluno aprovado. Nota: {nota}");
}
else
{
    Console.WriteLine($"Aluno reprovado. Nota: {nota}");
}

Console.WriteLine();

Console.WriteLine("Pressione qualquer tecla para finalizar...");

Console.ReadKey();