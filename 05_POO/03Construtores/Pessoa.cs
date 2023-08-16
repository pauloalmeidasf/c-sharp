namespace Classes;

internal class Pessoa
{

    public Pessoa()
    {

        Console.WriteLine("Nenhum nome foi informado - Construtor Padrão Pessoa");

    }

    public Pessoa(string nome)
    {

        Console.WriteLine($"Pessoa informada: {nome} - Construtor Parametrizado Pessoa");

    }

}
