namespace Classes;

internal class Pessoa
{

    public string? Nome { get; set; }

    //virtual: permite que o método seja sobrescrito
    public virtual void ExibeNome()
    {

        Console.WriteLine($"Eu sou uma pessoa e meu nome é: {Nome}");

    }

}
