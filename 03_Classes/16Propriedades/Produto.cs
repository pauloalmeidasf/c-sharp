namespace Classes;

/*
 * Propriedade
 * 
 * São membros da classe que fornecem mecanismos para ler, gravar ou calcular o valor de um campo privado
 * 
 * Possuem métodos especiais chamados acessadores (get e set)
 * 
 * Os métodos acessadores permitem que os dados sejam acessados com facilidade e promovem a segurança e
 * privacidade dos métodos
 * 
 * get: retorna um valor da propriedade
 * set: atribui um valor à propriedade
 * 
 */

internal class Produto
{

    //public string? Nome { get; set; }

    private string? nome;

    public string? Nome
    {
        get
        {
            return nome;
        }
        set
        {
            nome = value;
        }
    }

    private decimal preco;

    public decimal Preco
    {
        get
        {
            return preco;
        }
        set
        {
            if (value < 5)
            {
                preco = 5;
            }
            else
            {
                preco = value;
            }
        }
    }

    private decimal desconto = 0.10m;

    public decimal Desconto
    {

        get { return desconto; }

    }

    public decimal PrecoFinal
    {

        get { return Preco - (Preco * Desconto); }

    }

    private int estoqueMinimo; //camelCase

    //PascalCase
    public int EstoqueMinimo
    {

        set { estoqueMinimo = value; }

    }

    public void Imprimir()
    {

        Console.WriteLine($"Nome: {Nome}\nPreço: {Preco:c}\nDesconto: {Desconto:p}\nPreço Final: {PrecoFinal:c}\n" +
            $"Estoque Mínimo: {estoqueMinimo}");

    }

}
