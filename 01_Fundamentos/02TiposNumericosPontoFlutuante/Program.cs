/*
 * Tipos Numéricos de Ponto Flutuante
 * Armazenado na memória Stack
 * Tipo: Valor
 * Referência 01: https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types
 * Referência 02: https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/builtin-types/value-types
 * 
 */

Console.WriteLine("Tipos numéricos de ponto flutuante");
Console.WriteLine();

//double. O sufixo d pode ser omitido. System.Double
double temperatura = 25.5;
double temperaturaAmbiente = 22.9d;

//float. Obrigatório o uso do sufixo f. System.Single
float peso = 25.5f;

//decimal. Obrigatório o uso do sufixo m. System.Decimal
decimal valorNota = 25.5m;

Console.WriteLine("Temperatura: " + temperatura);
Console.WriteLine("Peso: " + peso);
Console.WriteLine("Valor da Nota: " + valorNota);
Console.WriteLine();

Console.WriteLine("Comparação entre os tipos: double, float e decimal");
Console.WriteLine();

double valor1 = 1 / 9d;
float valor2 = 1 / 9f;
decimal valor3 = 1 / 9m;

Console.WriteLine("Double (1/9): " + valor1);
Console.WriteLine("Float (1/9): " + valor2);
Console.WriteLine("Decimal (1/9): " + valor3);
Console.WriteLine();

Console.WriteLine("Pressione enter para finalizar...");

Console.ReadKey();