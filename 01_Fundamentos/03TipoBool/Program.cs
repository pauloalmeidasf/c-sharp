/*
 * Tipo Bool
 * Armazenado na memória Stack
 * Tipo: Valor
 * Referência 01: https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/builtin-types/bool
 * 
 */

//boolean: armazena true ou false. System.Boolean
bool cadastrado = true;
bool pagamentoRealizado = false;

Console.WriteLine("Cadastrado? " + cadastrado);
Console.WriteLine("Pagamento Realizado? " + pagamentoRealizado);
Console.WriteLine();

Console.WriteLine("10 é igual a 30? " + (10 == 30));
Console.WriteLine("5 é igual a 5: " + (5 == 5));

int temperaturaIncial = 25;
int temperaturaFinal = 23;

bool verificacao = temperaturaFinal > temperaturaIncial;

Console.WriteLine("Temperaturatura final é maior que a temperatura inicial? " +  verificacao);

Console.WriteLine("Pressione enter para finalizar");
Console.ReadKey();