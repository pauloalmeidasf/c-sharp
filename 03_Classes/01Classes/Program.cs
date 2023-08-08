using Classes;

/*
 * A classe Pessoa poderá criar objetos do tipo Pessoa
 * 
 * Para criar objetos a partir de uma classe, usa-se a palavra-chave new
 * 
 * 
 */

Console.WriteLine("Classes e objetos");
Console.WriteLine();

//Declara objeto pessoa

//Pessoa pessoa = new Pessoa();
//Pessoa pessoa = new();

var pessoa = new Pessoa();

/*
 * pessoa é objeto do tipo Pessoa
 * pessoa é uma instância da classe Pessoa
 * 
 * Todos os membros da classe podem ser acessados por meio do objeto
 * 
 */

pessoa.nome = "Pedro";
pessoa.idade = 35;
pessoa.genero = 'M';

Console.WriteLine($"Pessoa: {pessoa.nome}. Idade Pessoa: {pessoa.idade}. Gênero Pessoa: {pessoa.genero}");
Console.WriteLine();

//Declara objeto cliente

var cliente = new Pessoa();

Console.WriteLine($"Cliente: {cliente.nome}. Idade Cliente: {cliente.idade}. Gênero Cliente: {cliente.genero}");
Console.WriteLine();

//Atribui o objeto pessoa ao objeto colaborador
var colaborador = pessoa;

Console.WriteLine($"Colaborador: {colaborador.nome}. Idade Colaborador: {colaborador.idade}. " +
    $"Gênero Colaborador: {colaborador.genero}");
Console.WriteLine();

pessoa.nome = "Lucas";
pessoa.idade = 45;
pessoa.genero = 'M';

Console.WriteLine($"Colaborador: {colaborador.nome}. Idade Colaborador: {colaborador.idade}. " +
    $"Gênero Colaborador: {colaborador.genero}");
Console.WriteLine();

Console.Write("Pressione qualquer tecla para finalizar...");

Console.ReadKey();