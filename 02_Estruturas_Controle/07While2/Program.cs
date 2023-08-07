/*
 * while
 * 
 * Executa uma instrução ou um bloco de instruções enquanto uma expressão booleana especificada é avaliada como true.
 * 
 * Referência: https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/statements/iteration-statements#the-while-statement
 * 
 */

Console.WriteLine("Loop while");
Console.WriteLine();

bool continuar = true;

while (continuar)
{

    Console.Write("Digite um número inteiro (Para sair, digite 0): ");
    var valor = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    if (valor == 0)
    {

        Console.WriteLine("O número 0 foi digitado. O loop será finalizado.");

        continuar = false;

    }

}

Console.WriteLine();

Console.WriteLine("Tabuada de um número");
Console.WriteLine();

int numero = 15;
int contador = 1;

if(numero > 0)
{

    Console.WriteLine($"Tabuada do número {numero}");
    Console.WriteLine();

    while (contador < 11)
    {
        Console.WriteLine($"{numero} * {contador}: {numero * contador}");
        contador++;
    }

}
else
{

    Console.WriteLine("Número inválido");

}

Console.WriteLine();

Console.Write("Pressione qualquer tecla para finalizar...");

Console.ReadKey();