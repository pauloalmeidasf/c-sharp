/*
 * Métodos Anônimos
 * 
 * Não possuem nome
 * 
 * Podem ser definidos usando a palavra-chave delegate
 * 
 * Usados sempre que um tipo de delegate for esperado
 * 
 * Referência: https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/operators/lambda-expressions
 * 
 */

Console.WriteLine("Métodos Anônimos");
Console.WriteLine();

static bool Busca(string nome)
{
    return nome.Equals("Henrique");
}

var lista = new List<string>
{
    "Mariana", "Cesar", "João", "Henrique"
};

string? resultadoMetodo = lista.Find(Busca);

Console.WriteLine($"Resultado da busca usando o método definido: {resultadoMetodo}");

Console.WriteLine();

string? resultadoMetodoAnonimo = lista.Find(delegate (string nome)
{
    return nome.Equals("Henrique");
});

Console.WriteLine($"Resultado da busca usando o método definido: {resultadoMetodoAnonimo}");

Console.WriteLine();

Console.Write("Pressione qualquer tecla para finalizar...");

Console.ReadKey();