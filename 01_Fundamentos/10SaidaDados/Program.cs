Console.WriteLine("Formatação da Saída de Dados");
Console.WriteLine();

int idade = 35;
string nome = "Eliza";

//Operador +

Console.WriteLine("Concatenação - Obsoleto");
Console.WriteLine();

Console.WriteLine(nome + " tem " + idade + " anos");
Console.WriteLine();

//Place Holder: usa {} com uma numeração (início em 0)

Console.WriteLine("Place Holders - Obsoleto");
Console.WriteLine();

Console.WriteLine("{0} tem {1} anos", nome, idade);
Console.WriteLine();

//Interpolação: usa $ antes da string e a variável a ser interpolada entre {}

Console.WriteLine("Interpolação");
Console.WriteLine();

Console.WriteLine($"{nome} tem {idade} anos");
Console.WriteLine();

Console.WriteLine("Pressiona qualquer tecla para finalizar...");

Console.ReadKey();