namespace Classes;

internal class Aluno : Pessoa
{

    public Aluno() : base()
    {

        Console.WriteLine("Nenhum nome foi informado - Construtor Padrão Aluno");

    }

    public Aluno(string nome) : base(nome)
    {

        Console.WriteLine($"Aluno informado: {nome} - Construtor Parametrizado Aluno");

    }

}
