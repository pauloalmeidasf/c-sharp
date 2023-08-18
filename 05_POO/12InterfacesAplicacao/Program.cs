using Classes;
using Interfaces;

Console.WriteLine("Interfaces - Exemplo Exportação");
Console.WriteLine();

IExportar json = new ExportaJson("livros.json");

json.Exportar();

Console.WriteLine();

Console.Write("Pressione qualquer tecla para finalizar...");

Console.ReadKey();