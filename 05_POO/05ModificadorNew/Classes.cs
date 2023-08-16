namespace Classes;

//Classe base
internal class Pessoa
{

    public string? Nome { get; set; }

    public string? CPF { get; set; }

    public string ExibirDados()
    {

        return $"Nome: {Nome}\nCPF: {CPF}";

    }

}

//Classe derivada
internal class Aluno : Pessoa
{

    public string? Curso { get; set; }

    //modificador new
    public new string ExibirDados()
    {

        return $"Nome: {Nome}\nCPF: {CPF}\nCurso: {Curso}";

    }

}
