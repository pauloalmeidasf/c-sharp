namespace Classes;

internal class Calculo
{

    public void Multiplicar(ref int x)
    {

        //x = x * 3;
        x *= 3;

        Console.WriteLine($"Valor do parâmtro x no método Multiplicar(): {x}");
        Console.WriteLine();

    }

}
