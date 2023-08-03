/*
 * Operadores Aritmeticos
 * 
 * + : adição
 * -  : subtração
 * *  : multiplicação
 * /   : divisão
 * % : módulo (resto da divisão)
 * 
 */

Console.Write("Informe o valor de x: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Informe o valor de y: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("Operadores Aritméticos");
Console.WriteLine();

Console.WriteLine($"Soma entre x e y: {x + y}");
Console.WriteLine($"Subtração entre x e y: {x - y}");
Console.WriteLine($"Multiplicação entre x e y: {x * y}");
Console.WriteLine($"Divisão entre x e y: {(double) x /  y}");
Console.WriteLine($"Módulo entre x e y: {x % y}");

Console.WriteLine();

Console.WriteLine("Classe Math");
Console.WriteLine();

Console.WriteLine($"Raiz quadrada de x: {Math.Sqrt(x)}");
Console.WriteLine($"Potência de x elevado a y: {Math.Pow(x,y)}");
Console.WriteLine($"Valor mínimo entre x e y: {Math.Min(x,y)}");
Console.WriteLine($"Valor máximo entre x e y: {Math.Max(x,y)}");
Console.WriteLine($"Coseno de x: {Math.Cos(x)}");
Console.WriteLine($"Seno de x: {Math.Sin(x)}");
Console.WriteLine($"Exponencial de x: {Math.Exp(x)}"); //e^x
Console.WriteLine();

Console.WriteLine("Pressione qualquer tecla para finalizar...");

Console.ReadKey();