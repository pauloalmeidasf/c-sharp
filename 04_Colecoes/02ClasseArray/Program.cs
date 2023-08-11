using System.Threading.Tasks.Dataflow;

Console.WriteLine("Classe Array");
Console.WriteLine();

static void ExibeArray(string[] pessoas)
{

	foreach (var item in pessoas)
	{

        Console.WriteLine($"Nome: {item}");

    }

}

string[] pessoas = { "João", "Thiago", "Pedro", "Susan", "Gabriela" };

Console.WriteLine("Exibe o array pessoas");
Console.WriteLine();

ExibeArray(pessoas);

Console.WriteLine();

Console.WriteLine("Exibe o array pessoas na ordem invertida");
Console.WriteLine();

Array.Reverse(pessoas);

ExibeArray(pessoas);

Console.WriteLine();

Console.WriteLine("Exibe o array pessoas de forma ordenada");
Console.WriteLine();

Array.Sort(pessoas);

ExibeArray(pessoas);

Console.WriteLine();

Console.Write("Informe o nome da pessoa: ");
var nome = Console.ReadLine();

var indice = Array.BinarySearch(pessoas, nome);

//indice >= 0: item encontrado; indice < 0, item não encontrado
//Array.BinarySearch é utilizado em array ordenado
//Refência Array.BinarySearch: https://learn.microsoft.com/pt-br/dotnet/api/system.array.binarysearch?view=net-7.0

if (indice >= 0)
{
    Console.WriteLine($"Nome encontrado no índice {indice}");
}
else
{
    Console.WriteLine($"Nome não encontrado");
}

Console.WriteLine();

Console.WriteLine("Pressione qualquer tecla para finalizar...");

Console.ReadKey();