namespace Classes;
internal class Produto
{

    //propriedades
    public string? Nome { get; set; }
    public decimal Preco { get; set; }

    //campo privado
    private static List<Produto> produtos = new()
    {
        new Produto{Nome = "Notebook", Preco = 7500},
        new Produto{Nome = "Monitor", Preco = 2500},
        new Produto{Nome = "Teclado", Preco = 250},
        new Produto{Nome = "Mouse", Preco = 150},
        new Produto{Nome = "Cadeira", Preco = 2500},
    };

    public static List<Produto> BuscarProduto()
    {

        return produtos;

    }

}