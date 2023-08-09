using Classes;

Console.WriteLine("Métodos com retorno");
Console.WriteLine();

var calcular = new Calculadora();

var resultado = calcular.Multiplicar(2,-7);

Console.WriteLine($"Multiplicação: {resultado}");

Console.WriteLine();

Console.Write("Pressione qualquer tecla para finalizar...");

Console.ReadKey();