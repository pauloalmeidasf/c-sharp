namespace Classes;

//Classe Base
internal class Pessoa
{

    public string? Nome { get; set; }

    public string? Email { get; set; }

    public void ExibirDados()
    {

        Console.WriteLine($"Nome: {Nome}\nEmail: {Email}");

    }

}
