using Dapper.Contrib.Extensions;
using System.Data.SqlClient;

namespace Classes;

internal class ProdutoRepositorio
{

    //Cadastrar Produto
    public static void CadastrarProduto()
    {

        Console.WriteLine();
        Console.WriteLine("Cadastrar Produto");
        Console.WriteLine();

        try
        {

            Console.Write("Informe o código da Categoria do Produto: ");

            int codigoCategoria = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o nome do Produto: ");

            string? descricao = Console.ReadLine();

            Console.Write("Informe o preço do Produto: ");

            double preco = Convert.ToDouble(Console.ReadLine());

            var produto = new Produto(codigoCategoria, descricao!, preco);

            using (var conexao = new SqlConnection(DB.conexao))
            {

                conexao.Insert<Produto>(produto);

            }

            Console.WriteLine();
            Console.WriteLine("Produto cadastrado com sucesso");
            Console.WriteLine();

        }
        catch (Exception)
        {

            throw new Exception("Não foi possível cadastrar o Produto");

        }

    }

    //Listar Produto
    public static void ListarProduto()
    {

        Console.WriteLine();
        Console.WriteLine("Listar Produtos");
        Console.WriteLine();

        try
        {

            using (var conexao = new SqlConnection(DB.conexao))
            {

                var lista = conexao.GetAll<Produto>();

                foreach (var item in lista)
                {

                    Console.WriteLine($"Id: {item.IdProduto}, Descrição: {item.Descricao}, Preço: {item.Preco}");

                }

            }

            Console.WriteLine();

        }
        catch (Exception)
        {

            throw new Exception("Não foi possível realizar a busca dos Produtos");

        }

    }

    //Atualizar Produto
    public static void AtualizarProduto()
    {

        Console.WriteLine();
        Console.WriteLine("Atualizar Produto");
        Console.WriteLine();

        try
        {

            Console.Write("Informe o código do Produto: ");

            var codigoProduto = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o código da Categoria: ");

            var codigoCategoria = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o nome do Produto: ");

            var descricao = Console.ReadLine();

            Console.Write("Informe o preço do Produto: ");

            var preco = Convert.ToDouble(Console.ReadLine());

            var produto = new Produto(codigoProduto, codigoCategoria, descricao!, preco);

            using (var conexao = new SqlConnection(DB.conexao))
            {

                conexao.Update<Produto>(produto);

            }

            Console.WriteLine();
            Console.WriteLine("Produto atualizado com sucesso");
            Console.WriteLine();

        }
        catch (Exception)
        {

            throw new Exception("Não foi possível atualizar o Produto");

        }

    }

    //Remover Produto
    public static void RemoverProduto()
    {

        Console.WriteLine();
        Console.WriteLine("Remover Produto");
        Console.WriteLine();

        try
        {

            Console.Write("Informe o código do Produto: ");

            var codigo = Convert.ToInt32(Console.ReadLine());

            var produto = new Produto()
            {
                IdProduto = codigo
            };

            using (var conexao = new SqlConnection(DB.conexao))
            {

                conexao.Delete<Produto>(produto);

            }

            Console.WriteLine();
            Console.WriteLine("Produto removido com sucesso");
            Console.WriteLine();

        }
        catch (Exception)
        {

            throw new Exception("Não foi possível remover o Produto");

        }

    }

}