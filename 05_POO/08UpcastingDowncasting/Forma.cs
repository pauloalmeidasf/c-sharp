namespace Classes;

//classe base (generalizada)
internal class Forma
{

    protected int X { get; set; }
    protected int Y { get; set; }

    public Forma(int x, int y)
    {

        X = x;
        Y = y;

    }

    //virtual: permite que o método seja sobrescrito na classe derivada
    public virtual void Desenhar()
    {

        Console.WriteLine($"Desenha Forma na posição ({X},{Y})");

    }

}
