/*
 * Expressão Lambda
 * 
 * Utilizada para criar métodos anônimos
 * 
 * Sintaxe:
 * 
 * (conjunto de parâmetros de entrada) => {bloco de instruções}
 * 
 * Observação: se houver mais de um parâmetro de entra, estes deverão se separados por vírgulas
 * 
 * Referência: https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/operators/lambda-expressions
 * 
 */

Console.WriteLine("Expressão Lambda");
Console.WriteLine();

var planetas = new List<string>
{
    "Marte", "Saturno","Plutão","Mercúrio", "Terra"
};

string? resultado = planetas.Find(p => p.Equals("Netuno"));

Console.WriteLine($"Resultado da busca utilizando expressão lambda: {resultado}");

Console.WriteLine();

Console.Write("Pressione qualquer tecla para finalizar...");

Console.ReadKey();