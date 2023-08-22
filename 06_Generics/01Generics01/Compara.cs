namespace Classes;

internal class Compara
{

    //Método Genérico

    //public void ComparaValores<TValue>(TValue t1, TValue t2)
    //{

    //    Console.WriteLine($"{t1?.Equals(t2)}");

    //}

    public void ComparaValores<T, K>(T t, K k)
    {

        Console.WriteLine($"{t} ({t?.GetType()}) é igual a {k} ({k?.GetType()}): {t?.Equals(k)}");

    }

}