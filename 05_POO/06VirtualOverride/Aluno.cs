namespace Classes;

internal class Aluno :  Pessoa
{

    //override: sobrescreve o método herdado
    public override void ExibeNome()
    {

        Console.WriteLine($"Eu sou um aluno e meu nome é {Nome}");

    }

}