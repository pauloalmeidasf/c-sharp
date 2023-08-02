/*
 * Entrada de dados
 * 
 * Console.ReadLine(): lê uma linha de entrada do teclado. Retorna uma string
 * Console.Read(): lê apenas um único caractere do teclado. Retorna o valor ASCII do caractere
 * Console.ReadKey(): lê apenas um único caractere do teclado (tecla). Retorna ConsoleKeyInfo
 * 
 * Referência 01: https://learn.microsoft.com/pt-br/dotnet/api/system.console.readline?view=net-7.0
 * Referência 02: https://learn.microsoft.com/pt-br/dotnet/api/system.console.read?view=net-7.0
 * Referência 03: https://learn.microsoft.com/pt-br/dotnet/api/system.console.readkey?view=net-7.0
 * 
 * Referência 04: https://www.ascii-code.com/
 *
 */


Console.WriteLine("Entrada de dados");
Console.WriteLine();

Console.WriteLine("Console.ReadLine()");
Console.WriteLine();

//Console.ReadLine()
Console.Write("Informe o nome: ");
string nome = Console.ReadLine();

Console.Write("Informe a idade: ");
int idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

Console.WriteLine($"{nome} tem {idade} anos");
Console.WriteLine();

//Console.Read()

Console.WriteLine("Console.Read()");
Console.WriteLine();

Console.Write("Informe um caracter: ");
int codigo = Console.Read();
char caracter = Convert.ToChar(codigo);

Console.WriteLine();

Console.WriteLine($"Código do caracter {caracter}: {codigo}");
Console.WriteLine();

//Console.ReadKey()

Console.WriteLine("Console.ReadKey()");
Console.WriteLine();

Console.Write("Pressione uma tecla: ");
ConsoleKeyInfo tecla = Console.ReadKey();
Console.ReadLine();

Console.WriteLine();

Console.WriteLine($"Tecla utilizada: {tecla.Key}");

Console.WriteLine();

Console.WriteLine("Pressione qualquer tecla para finalizar...");

Console.ReadKey();