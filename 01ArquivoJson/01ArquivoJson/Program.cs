using Classes;

Console.WriteLine("Trabalhando com arquivos Json");
Console.WriteLine();


string? diretorio = @"c:\curso-csharp\aula-arquivos\";

string? arquivo = @"c:\curso-csharp\aula-arquivos\clima.json";

var lista = Clima.ObterDados();

//Salvar Json

//Verifica se o diretório não existe. Observar o operador NOT (!)
if (! Directory.Exists(diretorio))
{

    Directory.CreateDirectory(diretorio);

}

try
{

    Console.WriteLine("Salva o arquivo");
    Console.WriteLine();
    await Arquivo.SalvarJsonAsync(arquivo, lista);
    Console.WriteLine("Arquivo salvo com sucesso.");

}
catch (Exception e)
{

    Console.WriteLine(e.Message);
	
}

Console.WriteLine();

//Ler Json

try
{

    Console.WriteLine("Leitura do arquivo Json");
    Console.WriteLine();

    await Arquivo.LerJsonAsync(arquivo);

}
catch (Exception e)
{

    Console.WriteLine(e.Message);

}

Console.WriteLine();

Console.Write("Pressione qualquer tecla para continuar...");
Console.WriteLine();

Console.ReadKey();

//Excluir Json

try
{

    Console.WriteLine("Exclusão do arquivo");
    Console.WriteLine();

    Arquivo.ExcluirJson(arquivo);

    Console.WriteLine("Aquivo excluído com sucesso");

}
catch (Exception e)
{

    Console.WriteLine(e.Message);

}

Console.WriteLine();

Console.Write("Pressione qualquer tecla para finalizar...");

Console.ReadKey();