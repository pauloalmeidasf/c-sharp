/*
 * List<T>
 * 
 * Referência: https://learn.microsoft.com/pt-br/dotnet/api/system.collections.generic.list-1?view=net-7.0
 * 
 */

static void ExibeLista(List<string> lista)
{

    foreach (var item in lista)
    {

        Console.WriteLine($"Colaborador: {item}");

    }

}

Console.WriteLine("List<T>");
Console.WriteLine();

//List<string> pessoas = new List<string>();

var colaboradores = new List<string>() //se a lista for inicializada na declaração, os parênteses podem ser omitidos
{

    "Ana", "Sofia","Eliza","Lucas","Pedro","Thiago", "Vivian"

};

Console.WriteLine("Exibe os colaboradores da lista");
Console.WriteLine();

ExibeLista(colaboradores);

Console.WriteLine();

colaboradores[0] = "Ana Paula";

Console.WriteLine("Exibe os colaboradores da lista após atualização");
Console.WriteLine();

ExibeLista(colaboradores);

Console.WriteLine();

//erro de exceção
//colaboradores[7] = "Helena"; 

colaboradores.Add("Helena");

Console.WriteLine("Exibe os colaboradores da lista após inserir um item");
Console.WriteLine();

ExibeLista(colaboradores);

Console.WriteLine();

colaboradores.Insert(3, "Marcos");

Console.WriteLine("Exibe os colaboradores da lista após inserir um item em uma posição específica");
Console.WriteLine();

ExibeLista(colaboradores);

Console.WriteLine();

colaboradores.Remove("Vivian");

Console.WriteLine("Exibe os colaboradores da lista após remover um colaborador");
Console.WriteLine();

ExibeLista(colaboradores);

Console.WriteLine();

colaboradores.RemoveAt(6);

Console.WriteLine("Exibe os colaboradores da lista após remover um item de índice específico");
Console.WriteLine();

ExibeLista(colaboradores);

Console.WriteLine();

colaboradores.Sort();

Console.WriteLine("Exibe os colaboradores da lista após a ordenação");
Console.WriteLine();

ExibeLista(colaboradores);

Console.WriteLine();

var consulta = colaboradores.Contains("Pedro");

Console.WriteLine($"O colaborador Pedro está na lista: {consulta}");
Console.WriteLine();

//Método Find()

//Expressão Lambda
//Referência: https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/operators/lambda-expressions

var busca = colaboradores.FindAll(p => p.Contains("o"));

Console.WriteLine("Exibe os colabordores que contêm a letra 'o' no nome");
Console.WriteLine();

ExibeLista(busca);

Console.WriteLine();

Console.Write("Pressione qualquer tecla para finalizar....");

Console.ReadKey();