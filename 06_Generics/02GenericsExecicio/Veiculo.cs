/*
 * Sobrescrita do método ToString()
 * 
 * Referência: https://learn.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/how-to-override-the-tostring-method
 * 
 */

namespace Classes;

internal class Veiculo
{

    public string? Modelo { get; set; }

    //Sobrescreve o método ToString() da Classe
    public override string ToString()
    {
        return $"{Modelo}";
    }

}