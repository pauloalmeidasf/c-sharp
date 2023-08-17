namespace Classes;

//classe derivada (especializada)
internal class Circulo :  Forma
{

    public Circulo(int x, int y) : base(x, y) { }

    public override void Desenhar()
    {

        Console.WriteLine($"Desenha Círculo na posição ({X},{Y})");

    }

    public void Colorir()
    {

        Console.WriteLine("Colore Círculo");

    }

}