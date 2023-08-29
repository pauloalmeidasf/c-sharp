using System.Text.Json;

namespace Classes;

internal class Clima
{

    public DateTime Data { get; set; }
    public string? Cidade { get; set; }
    public byte Temperatura { get; set; }

    private static List<Clima> listaClima = new List<Clima>
    {
        new Clima(){Data = new DateTime(2023,08,24), Cidade = "São Paulo", Temperatura = 25},
        new Clima(){Data = new DateTime(2023,08,25), Cidade = "São Paulo", Temperatura = 23},
        new Clima(){Data = new DateTime(2023,08,26), Cidade = "São Paulo", Temperatura = 21},
        new Clima(){Data = new DateTime(2023,08,27), Cidade = "São Paulo", Temperatura = 22},
        new Clima(){Data = new DateTime(2023,08,28), Cidade = "São Paulo", Temperatura = 20},
    };

    public static List<Clima> ObterDados()
    {
        return listaClima;
    }

}