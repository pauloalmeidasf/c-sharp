/*
 * 
 * Queue<T>
 * 
 * Representa uma coleção primeiro a entrar, primeiro a sair
 * 
 * Referência: https://learn.microsoft.com/pt-br/dotnet/api/system.collections.generic.queue-1?view=net-7.0
 * 
 */

using Classes;

static void Exibe<T>(Queue<T> fila)
{

	foreach (var pedido in fila)
	{
		Console.WriteLine($"{pedido}");
	}

}

Console.WriteLine("Queue<T>");
Console.WriteLine();

//Queue<Pedido> filaPedido = new();
var filaPedido = new Queue<Pedido>();

//Insere pedidos na fila
filaPedido.Enqueue(new Pedido(1, 50));
filaPedido.Enqueue(new Pedido(2, 35.9m));
filaPedido.Enqueue(new Pedido(3, 55));

Console.WriteLine($"Total de pedidos na fila: {filaPedido.Count}");
Console.WriteLine();

Console.WriteLine("Pedidos na fila: ");
Console.WriteLine();

Exibe(filaPedido);

Console.WriteLine();

Console.WriteLine($"Primeiro da fila: {filaPedido.Peek()}");
Console.WriteLine();

if(filaPedido.Count > 0)
{

	filaPedido.Dequeue();

}

Console.WriteLine($"Primeiro da fila após atendimento anterior: {filaPedido.Peek()}");
Console.WriteLine();

var numeroPedido = 5;

Pedido? pedido = filaPedido.FirstOrDefault(a => a.Numero == numeroPedido);

if(pedido != null)
{

	Console.WriteLine($"Pedido número {numeroPedido} encontrado na fila");

}
else
{
    Console.WriteLine($"Pedido número {numeroPedido} não encontrado na fila");
}

Console.WriteLine();

Console.Write("Pressione qualquer tecla para finalizar...");

Console.ReadKey();