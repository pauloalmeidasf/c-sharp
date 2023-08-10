namespace Classes;

/*
 * A palavra-chave out permite que os argumentos sejam passados por referência
 * 
 * out é utilizado para transferir os dados para fora do método
 * 
 * 
 */

internal class Circulo
{

    public double CalcularArea(double raio)
    {

        double area = Math.PI * Math.Pow(raio, 2);

        return area;

    }

    public double CalcularPerimetro(double raio)
    {

        double perimetro = 2 * Math.PI * raio;

        return perimetro;

    }

    public double CalcularAreaPerimetro(double raio, out double area)
    {

        area = Math.PI * Math.Pow(raio, 2);

        double perimetro = 2 * Math.PI * raio;

        return perimetro;

    }

}
