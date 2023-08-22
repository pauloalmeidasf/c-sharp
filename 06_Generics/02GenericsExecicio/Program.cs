using Classes;

Console.WriteLine("Classe Genérica - Dados Tipo Inteiro");
Console.WriteLine();

var dado = new Dados<int>();

dado.Adicionar(5);
dado.Adicionar(15);
dado.Adicionar(25);

dado.Exibir();

Console.WriteLine();

Console.WriteLine("Classe Genérica - Dados Veículo");
Console.WriteLine();

//var teste = new Veiculo()
//{
//    Modelo ="Mustang",

//};

//var teste2 = new Veiculo()
//{
//    Modelo = "Ferrari",

//};

//teste.Modelo = "";

var veiculo = new Dados<Veiculo>();

veiculo.Adicionar(new Veiculo { Modelo = "Corolla" });
veiculo.Adicionar(new Veiculo { Modelo = "Civic" });
veiculo.Adicionar(new Veiculo { Modelo = "Fusca" });
veiculo.Adicionar(new Veiculo { Modelo = "Gol" });

veiculo.Exibir();

Console.WriteLine();

Console.Write("Pressione qualquer tecla para finalizar...");

Console.ReadKey();