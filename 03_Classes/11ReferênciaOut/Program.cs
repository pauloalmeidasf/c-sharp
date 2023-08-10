using Classes;

Console.WriteLine("Referência out");
Console.WriteLine();

var raio = 3.5;
var circulo = new Circulo();

double perimetro = circulo.CalcularAreaPerimetro(raio, out double areaCirculo);

Console.WriteLine($"Área do círculo: {areaCirculo}");
Console.WriteLine();

Console.WriteLine($"Perímetro do círculo: {perimetro}");
Console.WriteLine();

Console.WriteLine("Pressione qualquer tecla para finalizar...");

Console.ReadKey();