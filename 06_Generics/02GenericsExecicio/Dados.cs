namespace Classes;

internal class Dados<T> //where T : Veiculo
{

    //private List<T> dados = new List<T>();
    private List<T> dados = new();

    public void Adicionar(T item)
    {

        dados.Add(item);

    }

    public void Exibir()
    {

        foreach (var item in dados)
        {

            Console.WriteLine($"Dado: {item}");

        }

    }

}
