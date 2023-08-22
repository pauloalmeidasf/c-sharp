/*
 * Generics
 * 
 * Genéricos são classes, estruturas, interfaces e métodos que possuem parâmetros de tipos para um ou mais dos tipos
 * que eles armazenam
 * 
 * Uma classe de coleção genérica pode usar um parâmetro de tipo como um espaço reservado para o tipo de objetos
 * que ela armazena; os parâmetros de tipo aparecem como os tipos de seus campos e os tipos de parâmetros de seus
 * métodos
 * 
 * Um método genérico pode usar seu parâmetro de tipo como o tipo de seu valor de retorno ou como o tipo de um de seus
 * parâmetros formais
 * 
 * Os genéricos permitem personalizar um método, uma classe, uma estrutura ou uma interface para o tipo exato de dados
 * no qual ele atua
 * 
 * Restrições podem ser implementadas em tipos genéricos (ver referência 02)
 * 
 * Referência 01 - Definição e implementação: https://learn.microsoft.com/pt-br/dotnet/standard/generics/
 * 
 * Referência 02 - Restrições: https://learn.microsoft.com/pt-br/dotnet/csharp/programming-guide/generics/constraints-on-type-parameters
 * 
 */

using Classes;

Console.WriteLine("Métodos Genéricos");
Console.WriteLine();

var compara = new Compara();

compara.ComparaValores(10, 10);
compara.ComparaValores(10, 10.5);
compara.ComparaValores("10", "10");
compara.ComparaValores("10", 10);
compara.ComparaValores("10.5", 10.5);

Console.WriteLine();

Console.WriteLine("Classes Genéricas");
Console.WriteLine();

//Formas de declaração (instanciação) de um objeto
Compara teste1 = new Compara();
Compara teste2 = new();
var teste3 = new Compara();

//Formas de declaração (instanciação) de objeto de Classe Genérica
ComparaGenerico<int, int> teste4 = new ComparaGenerico<int, int>();
ComparaGenerico<int, int> teste5 = new();
var test6 = new ComparaGenerico<int, int>();

ComparaGenerico<int, int> comparaGenerico1 = new();
ComparaGenerico<int, double> comparaGenerico2 = new();
ComparaGenerico<int, string> comparaGenerico3 = new();

comparaGenerico1.ComparaValores(10, 10);
comparaGenerico2.ComparaValores(10, 10.8);
comparaGenerico3.ComparaValores(10,"10");

Console.WriteLine();

Console.Write("Pressione qualquer tecla para finalizar....");

Console.ReadKey();