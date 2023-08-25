/*
 * 
 * LINQ - Language Integrated Query
 * 
 * Recupera dados de uma fonte de dados (coleção, banco de dados, etc)
 * 
 * Referência 01: https://learn.microsoft.com/pt-br/dotnet/csharp/programming-guide/concepts/linq/introduction-to-linq-queries
 * 
 * Referência 02: https://learn.microsoft.com/pt-br/dotnet/csharp/linq/
 * 
 * Referência 03: https://learn.microsoft.com/pt-br/dotnet/csharp/linq/write-linq-queries
 * 
 */

var lista = new List<string>
{
    "Mariana","Cecília","Rafael","Taís","José"
};

//sintaxe de consulta

//var consulta =

//    from nome in lista
//    where nome.Contains('a')
//    orderby nome
//    select nome;

var consulta =
    (from nome in lista
    where nome.Contains('a')
    orderby nome
    select nome).ToList(); //converte para List<T>

Console.WriteLine("Resultado - Sintaxe de Consulta");
Console.WriteLine();

foreach (var item in consulta)
{
    Console.WriteLine($"Nome: {item}");
}

Console.WriteLine();

//sintaxe de método

var nomes = lista.Where(nome => nome.Contains('a')).OrderBy(p => p);

Console.WriteLine("Resultado - Sintaxe de Consulta");
Console.WriteLine();

foreach (var item in nomes)
{
    Console.WriteLine($"Nome: {item}");
}

Console.WriteLine();

Console.Write("Pressione qualquer tecla para finalizar...");

Console.ReadKey();