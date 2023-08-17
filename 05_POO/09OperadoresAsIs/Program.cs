using Classes;

/*
 * Operador "as"
 * 
 * Converte explicitamente o resultado de uma expressão para uma determinada referência ou tipo de valor anulável
 * 
 * Se a conversão não for possível, o operador "as" retornará null
 * 
 * O operador "as" nunca gera uma exceção
 * 
 * Referência: https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/operators/type-testing-and-cast#as-operator
 * 
 */

Console.WriteLine("Operador as");
Console.WriteLine();

Circulo circulo = new Circulo(3, 5);

//upcasting (implícito/automático)
Forma f1 = circulo;

//downcasting (conversão explícita): pode ocorrer uma exceção
//Circulo c1 = (Circulo)f1;

Veiculo? veiculo = new Veiculo();

Circulo? c1 = f1 as Circulo;

if (c1 != null)
{

    c1.Desenhar();
    c1.Colorir();

}
else
{

    Console.WriteLine("f1 não é um Circulo");

}

/*
 * Operador is
 * 
 * Retorna true ou false
 * 
 * Verifica se o tipo do resultado de uma expressão em tempo de execução é compatível com determinado tipo especificado
 * 
 * Testa um resultado de expressão em relação a um padrão
 * 
 * Retorna true quando o resultado de uma expressão não é nulo
 * 
 * Referência: https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/operators/type-testing-and-cast#is-operator
 * 
 */

Console.WriteLine("Operador is");
Console.WriteLine();

Circulo novoCirculo = new Circulo(8, 12);

//upcasting (implícito/automático)
Forma f2 = novoCirculo;

//verifica se o downcasting (conversão explícita) é possível

if (veiculo is Circulo)
{

    Circulo? c2 = f2 as Circulo;

    c2?.Desenhar();
    c2?.Colorir();

}
else
{

    Console.WriteLine("f2 não é um Círculo...");

}

Console.WriteLine();

Console.Write("Pressione qualquer tecla para finalizar...");

Console.ReadKey();