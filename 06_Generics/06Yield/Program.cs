/*
 * 
 * yield
 * 
 * Fornece o próximo valor de uma iteração
 * 
 * Referência: https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/statements/yield
 * 
 */

static IEnumerable<int> NumerosPositivos(IEnumerable<int> colecao)
{

	foreach (var item in colecao)
	{
		if(item >= 0)
		{
            yield return item;
        }
		//else
		//{
		//	yield break;
		//}
	}
}

Console.WriteLine("Instrução Yield");
Console.WriteLine();

var numeros = new int[]
{
    2,3,-5,6,7,-7,8,9
};

var numerosPositivos = NumerosPositivos(numeros);

Console.WriteLine("Números positivos da coleção");
Console.WriteLine();

foreach (var item in numerosPositivos)
{
	Console.Write($"{item} ");
}

Console.WriteLine();
Console.WriteLine();

Console.Write("Pressione qualquer tecla para finalizar...");

Console.ReadKey();