namespace Classes;

internal class Calculo
{

    //public static double Soma(double[] numeros)
    //{

    //    double soma = 0;

    //    foreach(var numero in numeros)
    //    {
    //        soma +=numero;
    //    }

    //    return soma;

    //}

    public static double Soma(params double[] numeros)
    {

        double soma = 0;

        foreach (var numero in numeros)
        {
            soma += numero;
        }

        return soma;

    }

}