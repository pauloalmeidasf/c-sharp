using Classes;


Console.WriteLine("Modificador Params");
Console.WriteLine();

//double[] valores = new double[4] { 2, 3, 5, 7 };
//double[] valores = new double[] { 2, 3, 5, 7 };

double[] valores = { 2, 3, 5, 7 };

Console.WriteLine($"Valor do array no índice 0: {valores[0]}");
Console.WriteLine();

valores[0] = 1;

Console.WriteLine($"Valor do array no índice 0: {valores[0]}");
Console.WriteLine();

//erro de exceção
//valores[4] = 9; 

var soma = Calculo.Soma(valores);

Console.WriteLine($"Soma dos valores do array: {soma}");
Console.WriteLine();

Console.WriteLine($"Soma dos valores: {Calculo.Soma(1,3,5,7)}");
Console.WriteLine();

Console.Write("Pressione qualquer tecla para finalizar...");

Console.ReadKey();