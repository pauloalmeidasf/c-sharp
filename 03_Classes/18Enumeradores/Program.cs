using Enumeradores;

Console.WriteLine("Enumeradores");
Console.WriteLine();

var dia = DiasSemana.Domingo;
var diaNumerico = (int)dia;

Console.WriteLine($"Dia da semana: {dia}, dia {diaNumerico} da senama");
Console.WriteLine();

var categoria = Categorias.Livro;
var categoriaNumerica = (int)categoria;

Console.WriteLine($"Categoria: {categoria}, item {categoriaNumerica} da categoria");
Console.WriteLine();

var rgb = RGB.Blue;
var rgbNumerico = (byte)rgb;

Console.WriteLine($"Cor: {rgb}, item {rgbNumerico} do enum RGB");
Console.WriteLine();

var valor = 4;
var enumDiaSemana = (DiasSemana)valor;

Console.WriteLine($"Dia Semana selecionado: {enumDiaSemana}");
Console.WriteLine();

Console.WriteLine("Pressione qualquer tecla para continuar..");

Console.ReadKey();