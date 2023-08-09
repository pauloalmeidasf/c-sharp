using Classes;

var nome = "Maria";
var idade = 40;
var cargo = "Médica";

var colaborador = new Colaborador(nome,cargo, idade);

colaborador.Imprimir();

Console.Write("Pressione qualque tecla para finalizar...");

Console.ReadKey();