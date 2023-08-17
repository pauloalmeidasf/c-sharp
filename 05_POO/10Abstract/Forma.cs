namespace Classes;

internal abstract class Forma
{

    protected double Area { get; set; }
    protected double Perimetro { get; set; }

    //métodos abstratos
    //só podem ser declarados em classes abstratas
    //não é possível utilizar os modificadores static e virtual
    //são implementados nas classes derivadas

    public abstract double CalcularArea();
    public abstract double CalcularPerimetro();

    //método normal
    public string Descricao()
    {

        return "Classe abstrata Forma";

    }

}