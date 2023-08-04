/*
 * if-else-else
 * 
 * Referência: https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/statements/selection-statements#the-if-statement
 * 
 */

Console.WriteLine("Instrução if-else-if");
Console.WriteLine();

var idade = 20;

//até 15: jovem
//16 até 64: adulto
//65 aé 99: idoso
//Acima 99: centenário

if(idade < 16)
{
    Console.WriteLine($"Faixa etária: jovem");
}
else if(idade < 65)
{
    Console.WriteLine($"Faixa etária: adulto");
}
else if(idade < 100)
{
    Console.WriteLine($"Faixa etária: idoso");
}
else
{
    Console.WriteLine($"Faixa etária: centenário");
}

Console.WriteLine();

Console.WriteLine("Pressione qualquer tecla para finalizar...");

Console.ReadKey();