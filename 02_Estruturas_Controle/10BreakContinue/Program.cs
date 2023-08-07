/*
 * 
 * break
 * 
 * Encerra a instrução de iteração mais próxima (for, while, do, foreach) ou a instrução switch
 * 
 * Referência: https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/statements/jump-statements#the-break-statement
 * 
 */

Console.WriteLine("Uso do comando break");
Console.WriteLine();

var i = 1;

do
{

    Console.WriteLine($"i: {i} ");

    i++;

    if (i > 10)
    {

        Console.WriteLine("encerra o loop");

        break; //interromper o loop

    }

    Console.WriteLine("continua o loop");

} while (i <= 15);

Console.WriteLine();

/*
 * 
 * continue
 * 
 * Inicia uma nova iteração da instrução de iteração mais próxima (for, foreach, while, do)
 * 
 */

Console.WriteLine("Uso do comando continue");
Console.WriteLine();

int k = 1;

while(k < 20)
{

    if(k == 8)
    {
        k++;

        continue;
    }

    Console.WriteLine($"k: {k}");

    k++;

}

Console.Write("Pressione qualquer tecla para finalizar...");

Console.ReadKey();