using System.ComponentModel.DataAnnotations.Schema;

namespace Classes;

//Annotations
[Table("TBProdutos")]
internal class Produto
{

    public int IdProduto { get; set; }
    public int IdCategoria { get; set; }
    public string? Descricao { get; set; }
    public double Preco { get; set; }

    public Produto() { }

    public Produto(int idCategoria, string descricao, double preco)
    {
        IdCategoria = idCategoria;
        Descricao = descricao;
        Preco = preco;
    }

    public Produto(int idProduto, int idCategoria, string descricao, double preco) : this(idCategoria, descricao, preco)
    {

        IdProduto = IdProduto;

    }

}