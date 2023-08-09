using Classes;

Console.WriteLine("Métodos com parâmetros");
Console.WriteLine();

var info = new Acesso();

var nome = "Ester";
var dataAtual = DateTime.Now.ToShortDateString();

info.ObterDadosAcesso(nome, dataAtual);

Console.WriteLine("Pressione qualquer tecla para finalizar...");

Console.ReadKey();