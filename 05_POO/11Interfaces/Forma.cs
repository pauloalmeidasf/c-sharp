using Interfaces;

namespace Classes;

//Classe Forma "implementa" as interfaces IForma e IControle
internal class Forma : IForma, IControle
{

    public string? Nome { get; set; }

    public void Colorir()
    {
        Console.WriteLine($"Colore {Nome}");
    }

    public void Plotar()
    {
        Console.WriteLine($"Plota {Nome}");
    }

    public string Teste()
    {
        return $"Testa {Nome}";
    }

}
