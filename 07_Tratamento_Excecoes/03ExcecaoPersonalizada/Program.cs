/*
 * Exceções personalizadas
 * 
 */

using Classes;

Console.WriteLine("Definição de Exceções Personalizadas");
Console.WriteLine();

var conta = new Conta(17255, "Cecília", 12000);

try
{

	conta.Depositar(3000);

	Console.WriteLine(conta);
	Console.WriteLine();

    conta.Sacar(2500);

    Console.WriteLine(conta);
    Console.WriteLine();

    conta.Sacar(25000);

    Console.WriteLine(conta);
    Console.WriteLine();

}
catch (SaldoException e)
{
	Console.WriteLine();
	Console.WriteLine(e.Message);
	Console.WriteLine();
}

Console.WriteLine();

Console.Write("Pressione qualque tecla para finalizar...");

Console.ReadKey();