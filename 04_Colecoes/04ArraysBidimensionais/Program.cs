Console.WriteLine("Arrays bidimensionais");
Console.WriteLine();

//declaração de um array bidimensional

int[,] pontos = new int[2, 2];

pontos[0, 0] = 10;
pontos[0, 1] = 15;
pontos[1, 0] = 20;
pontos[1, 1] = 25;

Console.WriteLine("Array pontos");
Console.WriteLine();

Console.WriteLine($"Ponto [0,0]: {pontos[0, 0]}");
Console.WriteLine($"Ponto [1,0]: {pontos[1, 0]}");

Console.WriteLine();

//declaração, inicialização e atribuição

//int[,] coordenadas = new int[2, 2] { { 10, 15 }, { 20, 25 }};
//int[,] coordenadas = new int[,] { { 10, 15 }, { 20, 25 }};

int[,] coordenadas = { { 10, 15 }, { 20, 25 }};

Console.WriteLine("Exibe dados do array bidimensional - Loop for");
Console.WriteLine();

for (int i = 0; i < coordenadas.GetLength(0); i++)
{

	for (int j = 0; j < coordenadas.GetLength(1); j++)
	{

		Console.Write($"{coordenadas[i,j]} ");

	}

	Console.WriteLine();

}

Console.WriteLine();

Console.WriteLine("Exibe dados do array bidimensional - Loop foreach");
Console.WriteLine();

foreach (var c in coordenadas)
{

	Console.Write($"{c} ");

}

Console.WriteLine();
Console.WriteLine();

Console.Write("Pressione qualquer tecla para finalizar...");

Console.ReadKey();