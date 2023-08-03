/*
 * Operadores Lógicos
 * 
 * &&: AND: Retorna false se uma das condições for false
 * ||   : OR: Retorn true se uma das condições for true
 * !   : NOT. Inverte o valor lógico
 * 
 * Referência: https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/operators/boolean-logical-operators
 * 
 */

Console.WriteLine("Operadores Lógicos");
Console.WriteLine();

bool t1 = 5 >= 7;
bool t2 = 9 != 8;
bool resultado;

//operador &&
resultado = t1 && t2;
Console.WriteLine($"t1 && t2: {resultado}");

Console.WriteLine();

//operador ||
resultado = t1 || t2;
Console.WriteLine($"t1 || t2: {resultado}");

Console.WriteLine();

//operador !
resultado = ! t2;
Console.WriteLine($"!t2: {resultado}");

Console.WriteLine();

Console.WriteLine("Pressione qualquer tecla para finalizar...");

Console.ReadKey();