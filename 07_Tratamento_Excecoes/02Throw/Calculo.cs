namespace Classes;

internal class Calculo
{

    public static double CalculoIMC(double peso, double altura)
    {
        if(altura <= 0)
        {
            throw new DivideByZeroException("Não é possível calcular IMC com altura menor ou igual a 0");
        }
        return peso / Math.Pow(altura, 2);
    }
}