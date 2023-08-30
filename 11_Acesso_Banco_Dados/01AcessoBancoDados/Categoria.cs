using System.ComponentModel.DataAnnotations.Schema;

namespace Classes;

//Annotations
[Table("TBCategorias")]

internal class Categoria
{
    public int Id { get; set; }
    public string? Descricao { get; set; }
    public Categoria() { }

    public Categoria(string descricao)
    {

        Descricao = descricao;

    }

    public Categoria(int id, string descricao) : this(descricao)
    {

        Id = id;

    }
}