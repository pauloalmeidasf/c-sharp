/*
 * 
 * Delegate Predicate<T>
 * 
 * Delegate predefinido na linguagem C#
 * 
 * Representa um método que recebe um único argumento do tipo T e retorna um valor booleano
 * 
 * Assintura: public delegate bool Predicate<in T>(T obj)
 * 
 * Aplicação: sempre que for necessário referenciar um método que recebe um parâmetro e retorna um bool
 * 
 * Referência: https://learn.microsoft.com/pt-br/dotnet/api/system.predicate-1?view=net-7.0
 * 
 */

//static bool Verificar(int numero)
//{
//    return numero % 2 == 0;
//}

Console.WriteLine("Delegate Predicate<T>");
Console.WriteLine();

var numero = 155;

//DelegatePar delPar = Verificar;

//referência um método que recebe um parâmetro e retorna bool
Predicate<int> delPar = x => x % 2 == 0;

var resultado = delPar(numero);

Console.WriteLine($"O número é par: {resultado}");

Console.ReadKey();

//delegate bool DelegatePar(int numero);