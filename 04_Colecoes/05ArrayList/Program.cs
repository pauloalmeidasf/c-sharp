/*
 * ArrayList
 * 
 *Referência: https://learn.microsoft.com/pt-br/dotnet/api/system.collections.arraylist?view=net-7.0
 *
 */

using System.Collections;

Console.WriteLine("ArrayList");
Console.WriteLine();

static void ExibirArrayList(ArrayList lista)
{

	foreach (var item in lista)
	{
		Console.WriteLine($"{item}");
	}

}

var lista = new ArrayList()
{

	"Notebook", "Teclado","Mouse","Câmera","Cadeira Gamer",100

};

Console.WriteLine("Mostra itens da lista");
Console.WriteLine();

ExibirArrayList(lista);

Console.WriteLine();

//Método Add()

lista.Add("Mesa");

Console.WriteLine("Mostra itens da lista após usar o método Add()");
Console.WriteLine();

ExibirArrayList(lista);

Console.WriteLine();

//Método Remove()

lista.Remove("Câmera");

Console.WriteLine("Mostra itens da lista após usar o método Remove()");
Console.WriteLine();

ExibirArrayList(lista);

Console.WriteLine();

//Método Sort()

lista.Sort();

Console.WriteLine("Mostra itens da lista após usar o método Sort()");
Console.WriteLine();

ExibirArrayList(lista);

Console.WriteLine();

Console.Write("Pressione qualquer tecla para finalizar...");

Console.ReadKey();