/*
 * 
 * Exemplo de expressão lambda
 *
 */

using Classes;

Console.WriteLine("Expressão Lambda - Exemplo Prático");
Console.WriteLine();

var produtos = Produto.BuscarProduto();

Console.WriteLine("Produtos com preços menores que R$2.100,00");
Console.WriteLine();

//o retorno padrão utilizando o método Where é IEnumerable<T>
//se for necessário obter os dados como uma List<T>, deve-se utilizar o método ToList()
var produtosAvaliados = produtos.Where(v => v.Preco < 2100).ToList();

foreach (var item in produtosAvaliados)
{
    Console.WriteLine($"Produto: {item.Nome}");
}

Console.WriteLine();

Console.Write("Pressione qualquer tecla para finalizar");

Console.ReadKey();