using Classes;

static void Menu()
{

    Console.WriteLine("Menu");

    Console.WriteLine(new string('-', 60));

    Console.WriteLine("0. Sair");
    Console.WriteLine("1. Cadastrar Categoria");
    Console.WriteLine("2. Listar Categoria");
    Console.WriteLine("3. Atualizar Categoria");
    Console.WriteLine("4. Remover Categoria");
    Console.WriteLine("5. Cadastrar Produto");
    Console.WriteLine("6. Listar Produto");
    Console.WriteLine("7. Atualizar Produto");
    Console.WriteLine("8. Remover Produto");

    Console.WriteLine(new string('-', 60));

}

Menu();

while (true)
{

    var opcao = 0;

    try
    {

        Console.Write("Escolha uma opção: ");

        opcao = Convert.ToInt32(Console.ReadLine());

    }
    catch (Exception)
    {

        Console.WriteLine("Opção inválida");
        Console.WriteLine("Pressione qualquer tecla para continuar");
        Console.ReadKey();
        Console.Clear();
        Menu();
        continue;

    }

    if(opcao == 0)
    {

        Console.WriteLine();
        Console.WriteLine("Operação finalizada");
        Console.WriteLine();

        Console.Clear();

        Menu();

        return;

    }

    //Cadastrar Categoria
    if(opcao == 1)
    {

        try
        {

            CategoriaRepositorio.CadastrarCategoria();

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            Menu();
            continue;

        }
        catch (Exception e)
        {

            Console.WriteLine(e.Message);
            Console.ReadKey();
            Console.Clear();
            Menu();
            continue;

        }

    }

    //Listar Categoria
    if (opcao == 2)
    {

        try
        {

            await CategoriaRepositorio.ListarCategoriasAsync();

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            Menu();
            continue;

        }
        catch (Exception e)
        {

            Console.WriteLine(e.Message);
            Console.ReadKey();
            Console.Clear();
            Menu();
            continue;

        }

    }

    //Atualizar Categoria
    if (opcao == 3)
    {

        try
        {

            CategoriaRepositorio.AtualizarCategoria();

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            Menu();
            continue;

        }
        catch (Exception e)
        {

            Console.WriteLine(e.Message);
            Console.ReadKey();
            Console.Clear();
            Menu();
            continue;

        }

    }

    //Remover Categoria
    if (opcao == 4)
    {

        try
        {

            CategoriaRepositorio.RemoverCategoria();

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            Menu();
            continue;

        }
        catch (Exception e)
        {

            Console.WriteLine(e.Message);
            Console.ReadKey();
            Console.Clear();
            Menu();
            continue;

        }

    }

    //Cadastrar Produto
    if (opcao == 5)
    {

        try
        {

            ProdutoRepositorio.CadastrarProduto();

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            Menu();
            continue;

        }
        catch (Exception e)
        {

            Console.WriteLine(e.Message);
            Console.ReadKey();
            Console.Clear();
            Menu();
            continue;

        }

    }

    //Listar Produto
    if (opcao == 6)
    {

        try
        {

            ProdutoRepositorio.ListarProduto();

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            Menu();
            continue;

        }
        catch (Exception e)
        {

            Console.WriteLine(e.Message);
            Console.ReadKey();
            Console.Clear();
            Menu();
            continue;

        }

    }

    //Atualizar Produto
    if (opcao == 7)
    {

        try
        {

            ProdutoRepositorio.AtualizarProduto();

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            Menu();
            continue;

        }
        catch (Exception e)
        {

            Console.WriteLine(e.Message);
            Console.ReadKey();
            Console.Clear();
            Menu();
            continue;

        }

    }

    //Remover Produto
    if (opcao == 8)
    {

        try
        {

            ProdutoRepositorio.RemoverProduto();

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            Menu();
            continue;

        }
        catch (Exception e)
        {

            Console.WriteLine(e.Message);
            Console.ReadKey();
            Console.Clear();
            Menu();
            continue;

        }

    }

}
