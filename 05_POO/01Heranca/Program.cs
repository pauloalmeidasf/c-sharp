/*
 * Herança
 * 
 * Permite que seja definida uma classe derivada (filha) que reutiliza (herda), estende ou modifica o comportamento
 * de uma classe base (mãe/pai)
 * 
 * Uma classe pode herdar apenas de uma única classe
 * 
 * Herança deve ser utilizada quando houver compatibilidade entre as classes
 * 
 * Referência: https://learn.microsoft.com/pt-br/dotnet/csharp/fundamentals/tutorials/inheritance#designing-the-base-class-and-derived-classes
 * 
 */

using Classes;

Console.WriteLine("Herança");
Console.WriteLine();

Console.WriteLine("Colaborador");
Console.WriteLine();

var colaborador = new Colaborador()
{
    Nome = "Vivian",
    Email = "vivian@outlook.com",
    Empresa = "Uber",
    Salario = 12000
};

//colaborador.Nome = "Vivian";
//colaborador.Email = "vivian@outlook.com";
//colaborador.Empresa = "Uber";
//colaborador.Salario = 12000;

colaborador.ExibirDados();

Console.WriteLine();

Console.WriteLine("Aluno");
Console.WriteLine();

var aluno = new Aluno()
{

    Nome = "Pedro",
    Curso = "Ciência da Computação",
    Email = "pedro@gmail.com"

};

aluno.ExibirDados();

Console.WriteLine();

Console.Write("Pressione qualquer tecla para finalizar...");

Console.ReadKey();