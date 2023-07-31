/*
 * Tipo String
 * 
 * Armazenado na memória Heap
 * Tipo: Referência
 * Valor padrão: null
 * 
 * Referência 01: https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0
 * Referência 02: https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/reference-types
 * 
 */

//string (System.String)
string curso = "Programando com CSharp na IMPACTA";

Console.WriteLine("Curso: " + curso);
Console.WriteLine();

string texto = "Texto inicial";

texto = "Texto inicial modificado";

texto = "Texto inicial modificado novamente";

Console.WriteLine("Texto: " + texto);
Console.WriteLine();

//O tipo string aceita a atribuição de null (valor não definido)
string nomeColaborador = null;

Console.WriteLine("Nome do Colaborador: " + nomeColaborador);

Console.WriteLine("Pressione enter para finalizar...");
Console.ReadKey();