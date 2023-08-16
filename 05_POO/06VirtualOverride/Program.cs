/*
 * 
 * virtual
 * 
 * É utilizado para modificar uma declaração de método ou propriedade e permitir que estes sejam substituídos
 * em uma classe derivada
 * 
 * Referência: https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/virtual
 * 
 */

/*
 * 
 * override
 * 
 * É necessário par estender ou modificar a implmentação abstrata ou virtual de um método ou propriedade herdada
 * 
 * Referência 01: https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/override
 * 
 * Referência 02: https://learn.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/knowing-when-to-use-override-and-new-keywords
 * 
 */

using Classes;

Console.WriteLine("Virtual e Override");
Console.WriteLine();

var aluno = new Aluno()
{

    Nome = "Gustavo"

};

aluno.ExibeNome();

var colaborador = new Colaborador()
{

    Nome = "Débora"

};

colaborador.ExibeNome();

Console.Write("Pressione qualquer tecla para finalizar....");

Console.ReadKey();