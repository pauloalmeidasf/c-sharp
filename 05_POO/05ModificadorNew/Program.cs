/*
 * 
 * Modificador new
 * 
 * A palavra-chave new oculta explicitamente um membro herdado de uma classe base
 * 
 * Referência: https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/new-modifier
 * 
 */

using Classes;

Console.WriteLine("Modificador new");
Console.WriteLine();

var aluno = new Aluno()
{

    Nome = "Júlia",
    CPF = "98765432100",
    Curso = "Direito"

};

var pessoa = new Pessoa()
{

    Nome = "Marcelo",
    CPF = "12345678900"
    
};

Console.WriteLine(aluno.ExibirDados());

Console.WriteLine();

Console.WriteLine(pessoa.ExibirDados());

Console.WriteLine();

Console.Write("Pressione qualquer tecla para finalizar...");

Console.ReadKey();