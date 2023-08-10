using Estruturas;

Console.WriteLine("Estruturas - struct");
Console.WriteLine();

var cliente = new Cliente();

cliente.Nome = "Eleni";
cliente.Idade = 35;

Console.WriteLine($"Cliente: {cliente.Nome}\nIdade: {cliente.Idade}");
Console.WriteLine();

Console.Write("Pressione qualquer tecla para finalizar...");

Console.ReadKey();
