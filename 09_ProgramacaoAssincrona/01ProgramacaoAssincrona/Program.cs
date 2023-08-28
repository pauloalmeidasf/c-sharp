/*
 * Programação Síncrona
 * 
 * Geralmente, todos os programas desenvolvidos em C# são executados de forma síncrona
 * 
 * Executa as tarefas em sequência
 * 
 * Uma tarefa deve ser concluída antes de iniciar a execução da próxima tarefa
 * 
 * Existe o bloqueio da thread principal. Thread: linha de execução
 * 
 */

/*
 * Programação Assíncrona
 * 
 * Permite que a aplicação execute várias tarefas ao mesmo tempo (simultanemente) sem bloquear a thread principal
 * 
 * É possível iniciar uma tarefa e continuar outras tarefas enquanto a primeira está em andamento
 * 
 * Retorno de métodos assíncronos: Task e Task<T> (é uma promessa de execução de uma tarefa no futuro)
 * 
 * Task: usado em métodos assíncronos que não retornam um valor
 * Task<T>: usado em métodos assíncronos que retornam um valor
 * 
 * Task e Task<T> são tipos-referência e são armazenados na memória Heap
 * 
 * palavra chave async: é usada para indicar que método pode ser executado de forma assíncrona
 * palavra chave await: é usada para aguardar a conclusão de uma tarefa assíncrona
 * 
 * Referência 01: https://learn.microsoft.com/pt-br/dotnet/csharp/asynchronous-programming/
 * Referência 02: https://learn.microsoft.com/pt-br/dotnet/csharp/asynchronous-programming/async-scenarios
 * Referência 03: https://learn.microsoft.com/pt-br/dotnet/csharp/asynchronous-programming/task-asynchronous-programming-model
 * 
 */

using Classes;

Console.WriteLine("Programação Assíncrona");
Console.WriteLine();

Console.WriteLine("Método Assíncrono com retorno");
Console.WriteLine();

//deve-se utilizar a palavra chave await ao invocar um método assíncrono
var totalCaracteres = await Dados.ObterTotalCaracteresAsync();

Console.WriteLine($"Total de Caracteres: {totalCaracteres}");
Console.WriteLine();

Console.WriteLine("Método Assíncrono sem retorno");
Console.WriteLine();

await Dados.ObterDadosAsync();

Console.WriteLine();

Console.WriteLine();

Console.Write("Pressione qualquer tecla para finalizar...");

Console.ReadKey();