using Classes;

Console.WriteLine("Métodos com parâmetros - objeto");
Console.WriteLine();

var aluno = new Aluno();

aluno.Consultar(aluno);

Console.WriteLine();

Console.WriteLine("Pressione qualquer tecla para finalizar...");

Console.ReadKey();
