using Interfaces;

namespace Classes;

//Classe Genérica
internal class ComparaGenerico<T, K> //where T : struct where K : ICompara
{

    public void ComparaValores(T t, K k)
    {

        Console.WriteLine($"{t} ({t?.GetType()}) e {k} ({k?.GetType()}) são iguais: {t?.Equals(k)}");

    }

}
