/*
 * Identificadores
 * 
 * Referência: https://learn.microsoft.com/pt-br/dotnet/csharp/fundamentals/coding-style/coding-conventions
 * 
 * É um nome atribuído a uma variável, membro, propriedade, namespace ou a um tipo (classe, interface, struct, etc)
 * 
 * Deve-se utilizar nomes significativos para inferir o propósito do identificador
 * 
 */

Console.WriteLine("Identificadores");
Console.WriteLine();

//Identificadores válidos

string nome;
int idade = 25;
int _valor;

nome = "João";

//Identificadores inválidos

//int 5idade;
//int $valor;
//int valor#total;
//string nome completo;

//Padrão de nomes de variáveis: convenção camel case

double descontoTotal;
decimal decontoTotalVenda;

//Padrão de nomes de constantes: convenção é usar maiúculas

const string PREFIXO = "41";

Console.WriteLine("Pressiona qualquer tecla para finalizar...");

Console.ReadKey();