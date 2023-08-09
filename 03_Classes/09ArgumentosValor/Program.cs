using Classes;

/*
 * Passagem de argumentos por valor
 * 
 * Uma cópia do valor do argumento é feita e passada para o parâmetro do método chamado
 * 
 * As alterações realizadas no parâmetro não afetam o argumento
 * 
 * As alterações na cópia não afetam o valor da variável original no método chamador
 * 
 */

Console.WriteLine("Argumentos por valor");
Console.WriteLine();

int x = 35;

Console.WriteLine($"Valor do argumento x antes de passar por valor: {x}");
Console.WriteLine();

var calculo = new Calculo();

calculo.Multiplicar(x);

Console.WriteLine();

Console.WriteLine($"Valor do argumento x depois de passar por valor: {x}");
Console.WriteLine();

Console.WriteLine("Pressione qualquer tecla para finalizar...");

Console.ReadKey();