using Interfaces;
namespace Classes;

internal class ExportaJson : IExportar
{

    protected string? Arquivo { get; set; }

    public ExportaJson(string arquivo)
    {
        Arquivo = arquivo;
    }

    public void Exportar()
    {
        Console.WriteLine($"Exporta {Arquivo}");
    }

}
