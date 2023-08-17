namespace Classes;

internal class Retangulo : Forma
{

    public double Base { get; set; }
    public double Altura { get; set; }

    public override double CalcularArea()
    {

        return Area = Base * Altura;

    }

    public override double CalcularPerimetro()
    {

        return Perimetro = 2 * (Base + Altura);

    }

}