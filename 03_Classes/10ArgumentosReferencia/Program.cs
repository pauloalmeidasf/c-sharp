using Classes;

/*
 * Passagem de argumentos por referência
 * 
 * Passa a referência (endereço) do local de memória dos argumentos para os parâmetros
 * 
 * As alterações realizadas no parâmetro afetam o argumento
 * 
 * É utilizada a palavra-chave ref
 * 
 */

Console.WriteLine("Argumentos por referência");
Console.WriteLine();

int x = 15;

Console.WriteLine($"Valor do argumento x antes de passar por referência: {x}");
Console.WriteLine();

var calculo = new Calculo();

calculo.Multiplicar(ref x);

Console.WriteLine($"Valor do argumento x depois de passar por referência: {x}");
Console.WriteLine();

Console.WriteLine("Pressione qualquer tecla para finalizar...");

Console.ReadKey();