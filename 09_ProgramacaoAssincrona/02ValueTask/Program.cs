/*
 * 
 * ValueTask: fornece o resultado esperado de uma operação assíncrona
 * 
 * ValueTask<T>: fornece um tipo valor que encapsula um Task<T> em um T
 * 
 * ValueTask e ValueTask<T> são tipos-valor (struct) e são armazenados na memória Stack
 * 
 * Referência: https://learn.microsoft.com/pt-br/dotnet/api/system.threading.tasks.valuetask-1?view=net-7.0
 * 
 */

static async ValueTask TempoEsperaAsync()
{

    Console.WriteLine("Aguarda 5 segundos antes de prosseguir");

    await Task.Delay(5000);

}

static async ValueTask<int> RetornaTempoEsperaAsync()
{

    Console.WriteLine("Aguarda 5 segundos antes de prosseguir");

    var tempo = 5000;

    await Task.Delay(tempo);

    return tempo;

}

Console.WriteLine("ValueTask e ValueTask<T>");
Console.WriteLine();

Console.WriteLine("Metodo sem retorno");
Console.WriteLine();

await TempoEsperaAsync();

Console.WriteLine();

Console.WriteLine("Metodo com retorno");
Console.WriteLine();

var tarefa = RetornaTempoEsperaAsync();

var tempoEspera = await tarefa;

Console.WriteLine($"Tempo de espera: {tempoEspera} milissegundos");
Console.WriteLine();

Console.Write("Pressione qualquer tecla para finalizar...");

Console.ReadKey();