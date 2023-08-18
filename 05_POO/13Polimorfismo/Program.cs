/*
 * Polimorfismo
 * 
 * Chamado de o terceiro pilar da programação orientada a objetos, depois de encapsulamento e herança
 * 
 * Polimorfismo signfica "várias formas"
 * 
 * Aspectos:
 * 
 * 1. Em tempo de execução, os objetos de uma classe derivada podem ser tratados como objetos de uma classe base, 
 * em locais como parâmetros de método, coleções e arrays. Quando este polimorfismo ocorre, o tipo declarado do objeto
 * não é mais idêntico ao seu tipo de tempo de execução
 * 
 * 2. As classes base podem definir e implementar métodos virtuais e as classes derivadas podem substituí-los, o que
 * significa que eles fornecem sua própria definição e implementação
 * 
 * Referência: https://learn.microsoft.com/pt-br/dotnet/csharp/fundamentals/object-oriented/polymorphism
 * 
 */

using Classes;

Console.WriteLine("Polimorfismo");
Console.WriteLine();

var figuras = new List<Figura>
{

    new Quadrado(),
    new Retangulo()

};

//figuras.Add(new Quadrado());
//figuras.Add(new Retangulo());

foreach (var item in figuras)
{

    Console.WriteLine(item.Imprimir());

}

Console.WriteLine();

Console.Write("Pressione qualquer tecla para finalizar...");

Console.ReadKey();