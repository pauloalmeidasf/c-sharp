namespace Classes;

internal partial class Pessoa
{

    public TimeSpan CalcularIdade(DateTime nascimento)
    {

        return DateTime.Now - nascimento;

    }

}
