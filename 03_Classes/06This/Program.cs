using Classes;

Console.WriteLine("Operador this");
Console.WriteLine();

var v = new Velocidade();

v.valor1 = 90;
v.valor2 = 110;

v.ExibirVelocidade();

Console.WriteLine("Pressione qualquer tecla para finalizar...");

Console.ReadKey();
