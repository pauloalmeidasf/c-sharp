/*
 * Interface IEnumerable<T>
 * 
 * Permite realizar a iteração em uma coleção
 * 
 * Referência: https://learn.microsoft.com/pt-br/dotnet/api/system.collections.generic.ienumerable-1?view=net-7.0
 * 
 */

static void Imprimir<T>(IEnumerable<T> colecao)
{
	foreach (var item in colecao)
	{
		Console.WriteLine(item);
	}
}

Console.WriteLine("Interface IEnumerable<T>");
Console.WriteLine();

var colaboradores = new List<string>
{
    "Ana", "Maria", "Rafael", "José"
};

//IEnumerable<string> colaboradoresEnumeravel = colaboradores;

Console.WriteLine("Imprime as lista de colaboradores");
Console.WriteLine();

Imprimir(colaboradores);

Console.WriteLine();

var notas = new double[] { 9.5, 8, 7.4, 6.2, 3 };

//IEnumerable<double> notasEnumeravel = notas;

Console.WriteLine("Imprime as notas dos alunos");
Console.WriteLine();

Imprimir(notas);

Console.WriteLine();

Console.Write("Pressione qualquer tecla para finalizar...");

Console.ReadKey();