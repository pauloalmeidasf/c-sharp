namespace Estruturas;

/*
 * structs
 * 
 * As structs são semelhantes às classes
 * 
 * Representam estruturas de dados que podem conter membros de dados e membros de métodos
 * 
 * As structs são do tipo valor e são armazenadas na memória Stack
 * 
 * Referência: https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/language-specification/structs
 * 
 */

public struct Cliente
{

    public string Nome { get; set; }
    public int Idade { get; set; }

    //Construtor
    public Cliente(string nome, int idade)
    {

        Nome = nome;
        Idade = idade;

    }

}