using Dapper.Contrib.Extensions;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;

namespace Classes;

/*
 * Bloco using
 * 
 * Referência: https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/statements/using
 * 
 */

internal class CategoriaRepositorio
{

    //Cadastrar Categoria
    public static void CadastrarCategoria()
    {

        Console.WriteLine();
        Console.WriteLine("Cadastrar Categorias");
        Console.WriteLine();

        try
        {

            Console.Write("Informe o nome da Categoria: ");

            string? descricao = Console.ReadLine();

            var categoria = new Categoria(descricao!);

            //bloco using
            using (var conexao = new SqlConnection(DB.conexao))
            {

                conexao.Insert<Categoria>(categoria);

            }

            Console.WriteLine();
            Console.WriteLine("Categoria cadastrada com sucesso");
            Console.WriteLine();

        }
        catch (Exception)
        {

            throw new Exception("Erro ao cadastrar Categoria");

        }

    }

    //Listar Categorias
    public static async Task ListarCategoriasAsync()
    {

        Console.WriteLine();
        Console.WriteLine("Listar Categorias");
        Console.WriteLine();

        try
        {

            using (var conexao = new SqlConnection(DB.conexao))
            {

                var tarefa = conexao.GetAllAsync<Categoria>();

                var lista = await tarefa;

                foreach (var item in lista)
                {
                    Console.WriteLine($"Id: {item.Id}, Descrição: {item.Descricao}");
                }

            }

            Console.WriteLine();

        }
        catch (Exception)
        {

            throw new Exception("Não foi possível realizar a busca das Categorias");

        }

    }

    //Atualizar Categoria
    public static void AtualizarCategoria()
    {

        Console.WriteLine();
        Console.WriteLine("Atualizar Categoria");
        Console.WriteLine();

        try
        {

            Console.Write("Informe o código da Categoria: ");

            int codigo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o nome da Categoria: ");

            string? descricao = Console.ReadLine();

            var categoria = new Categoria(codigo, descricao!);

            using (var conexao = new SqlConnection(DB.conexao))
            {

                conexao.Update<Categoria>(categoria);

            }

            Console.WriteLine();
            Console.WriteLine("Categoria atualizada com sucesso");
            Console.WriteLine();

        }
        catch (Exception)
        {

            throw new Exception("Não foi possível atualizar a Categoria");

        }

    }

    //Remover Categoria
    public static void RemoverCategoria()
    {

        Console.WriteLine();
        Console.WriteLine("Remover Categoria");
        Console.WriteLine();

        try
        {

            Console.Write("Informe o código da categoria: ");

            var codigo = Convert.ToInt32(Console.ReadLine());

            var categoria = new Categoria()
            {
                Id = codigo
            };

            using (var conexao = new SqlConnection(DB.conexao))
            {

                conexao.Delete<Categoria>(categoria);

            }

            Console.WriteLine();
            Console.WriteLine("Categoria removida com sucesso");
            Console.WriteLine();

        }
        catch (Exception)
        {

            throw new Exception("Não foi possível remover a categoria");

        }

    }

}