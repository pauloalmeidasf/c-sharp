/*
 * Modificador abstract
 * 
 * Indica que o item que está sendo modificado tem uma implementação ausente ou incompleta
 * 
 * Pode ser usado com classes, métodos, propriedades, indexadores e eventos
 * 
 * Utilizado para indicar que uma classe se destina somente a ser uma classe base de outras classes
 * 
 * Membros marcados como abstratos precisam ser implementados por classes não abstratas
 * que derivam da classe abstrata
 * 
 * Uma classe abstrata não pode ser instanciada
 * 
 * Referência: https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/abstract
 * 
 */

using Classes;

Console.WriteLine("Modificador abstract");
Console.WriteLine();

var retangulo = new Retangulo()
{
    Base = 3,
    Altura = 4
};

Console.WriteLine($"Área do retângulo: {retangulo.CalcularArea()} u.m");
Console.WriteLine();

Console.WriteLine($"Perímetro do retângulo: {retangulo.CalcularPerimetro()} u.m");
Console.WriteLine();

Console.Write("Pressione qualquer tecla para continuar...");

Console.ReadKey();