using Classes;

Console.WriteLine("Métodos Estáticos");
Console.WriteLine();

var dividir = Calculadora.Dividir(100, 50);
var multiplicar = Calculadora.Multiplicar(3, 5);

var calculo = new Calculadora();

Console.WriteLine($"Divisão: {dividir}");
Console.WriteLine();

Console.WriteLine($"Multiplicação: {multiplicar}");
Console.WriteLine();

Console.WriteLine($"Subtração: {calculo.Subtrair(-50, -75)}");
Console.WriteLine();

Console.WriteLine("Pressione qualquer tecla para finalizar...");

Console.ReadKey();