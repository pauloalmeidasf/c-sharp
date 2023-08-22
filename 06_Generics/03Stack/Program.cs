/*
 * 
 * Satack
 * 
 * Representa uma coleção último a entrar, primeiro a sair
 * 
 * Referência: https://learn.microsoft.com/pt-br/dotnet/api/system.collections.generic.stack-1?view=net-7.0
 * 
 * Aplicações: desfazer em um editor de texto, operações em avaliações matemáticas, operações complexas em
 * ciência da computação (memória, processadores, etc)
 * 
 */

static void Exibir<T>(Stack<T> numeros)
{

	foreach (var item in numeros)
	{

		Console.WriteLine(item);

	}

}

Console.WriteLine("Stack");
Console.WriteLine();

//Stack<int> valores = new();
var valores = new Stack<int>();


//Insere item na pilha
valores.Push(1000);
valores.Push(1005);
valores.Push(1010);

Console.WriteLine($"Total de itens na pilha: {valores.Count}");
Console.WriteLine();

Console.WriteLine($"Itens da pilha: ");
Console.WriteLine();

Exibir(valores);

Console.WriteLine();

//Remove item da pilha
valores.Pop();

Console.WriteLine($"Itens da pilha após remover item: ");
Console.WriteLine();

Exibir(valores);

Console.WriteLine();

Console.WriteLine($"Primeiro elemento da pilha: {valores.Peek()}");

Console.WriteLine();

if (valores.Contains(1005))
{
	Console.WriteLine("O valor procurado está na pilha.");
}
else
{
    Console.WriteLine("O valor procurado não está na pilha.");
}

Console.WriteLine();

Console.Write("Pressione qualquer tecla para finalizar...");

Console.ReadKey();