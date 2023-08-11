Console.WriteLine("Arrays");
Console.WriteLine();

//declaração e inicialização de um array
int[] numerosPares = new int[4] { 2, 4, 6, 8 };
int[] numerosPrimos = new int[] { 2, 3, 5, 7, 11 };
string[] pessoas = { "Ana", "Eliza", "Lucas", "Eleni", "Paulo" };

Console.WriteLine("Exibe os nomes das pessoas");
Console.WriteLine();

//em um array, o primeireo elemento alocado no índice 0
Console.WriteLine($"Pessoa no índice 1 do array: {pessoas[1]}");
Console.WriteLine($"Pessoa no índice 2 do array: {pessoas[2]}");

Console.WriteLine();

Console.WriteLine("Exibe todos os nomes das pessoas com o loop for");
Console.WriteLine();

for (int i = 0; i < pessoas.Length; i++)
{

    Console.WriteLine($"Pessoa no índice {i} do array: {pessoas[i]}");

}

Console.WriteLine();

Console.WriteLine("Exibe todos os nomes das pessoas com o loop foreach");
Console.WriteLine();

foreach (var p in pessoas)
{

    Console.WriteLine($"Pessoa: {p}");

}

Console.WriteLine();

Console.Write("Pressione qualquer tecla para finalizar...");

Console.ReadKey();