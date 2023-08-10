namespace Classes;

internal class Calculadora
{

    /*
     * Métodos estáticos (métodos de classe)
     * 
     * Utiliza o modificador static na declaração do método
     * 
     * São métodos que não dependem de um objeto para seremm acessados
     * 
     * Pertecem à classe e não a um objeto
     * 
     */

    public static double Somar(double n1, double n2)
    {

        return n1 + n2;

    }

    public double Subtrair(double n1, double n2)
    {

        return n1 - n2; //-50 - (-75) = -50 +75

    }

    public static double Multiplicar(double n1, double n2)
    {

        return n1 * n2;

    }

    public static double Dividir(double n1, double n2)
    {

        return n1 / n2;

    }

}