namespace Interfaces;

internal interface IForma
{

    public string? Nome { get; set; }

    //implementação de métodos em Interfaces é permitida a partir da versão 8 do C#
    public string Imprimir()
    {

        return $"Forma: {Nome}";

    }

    public string Teste();

}