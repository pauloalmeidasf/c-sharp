namespace Classes;
internal class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    private static List<Pessoa> pessoas = new()
    {
        new Pessoa("Cecília",23),
        new Pessoa("Murilo",32),
        new Pessoa("João",58),
        new Pessoa("Mariana",12),
        new Pessoa("Rafaela",17)
    };
    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
    public static List<Pessoa> Buscar()
    {
        return pessoas;
    }
}