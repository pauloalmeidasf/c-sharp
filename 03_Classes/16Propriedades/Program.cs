using Classes;

Console.WriteLine("Propriedades");
Console.WriteLine();

var produto = new Produto();

produto.Nome = "Notebook 15\" i7 16GB RAM 512GB SSD";
produto.Preco = 5800;
produto.EstoqueMinimo = 200;

produto.Imprimir();

Console.WriteLine();

Console.WriteLine("Pressione qualquer tecla para finalizar...");

Console.ReadKey();