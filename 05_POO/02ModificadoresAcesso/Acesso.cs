namespace Classes;

internal class Base
{

    public static void MetodoPublic()
    {

        Console.WriteLine("Método Public");

    }
    protected static void MetodoProtected()
    {

        Console.WriteLine("Método Protected");

    }
    private static void MetodoPrivate()
    {

        Console.WriteLine("Método Private");

    }

}

internal class Derivada : Base
{

    /*
     * A classe Derivada herda todos os membros (métodos, propriedades e campos) que são públicos (Public) e 
     * protegidos (Protected)
     * 
     */

    public static void TesteAcesso()
    {

        MetodoPublic();
        MetodoProtected();
        //MetodoPrivate();

    }

}

internal class Teste
{

    public static void TesteAcesso()
    {

        Base.MetodoPublic();
        //Base.MetodoProtected();

    }

}