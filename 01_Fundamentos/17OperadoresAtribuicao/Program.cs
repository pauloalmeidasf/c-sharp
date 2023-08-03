Console.WriteLine("Operadores de atribuição");
Console.WriteLine();

double x = 10;
x = 20;

Console.WriteLine("Operadores de Atribuição - Reduzido");
Console.WriteLine();

Console.WriteLine($"Valor de x: {x}");
Console.WriteLine($"x = x + 4: {x+=4}");
Console.WriteLine($"x = x - 2: {x-=2}");
Console.WriteLine($"x = x * 4: {x*=4}");
Console.WriteLine($"x = x / 2: {x/=2}");
Console.WriteLine($"x = x % 5: {x%=5}");
Console.WriteLine();

Console.WriteLine("Operadores de Atribuição - Convencional");
Console.WriteLine();

Console.WriteLine($"Valor de x: {x}");
Console.WriteLine($"x = x + 4: {x = x + 4}");
Console.WriteLine($"x = x - 2: {x = x - 2}");
Console.WriteLine($"x = x * 4: {x = x * 4}");
Console.WriteLine($"x = x / 2: {x = x / 2}");
Console.WriteLine($"x = x % 5: {x = x % 5}");

Console.WriteLine();

Console.WriteLine("Pressione qualquer tecla para finalizar...");

Console.ReadKey();