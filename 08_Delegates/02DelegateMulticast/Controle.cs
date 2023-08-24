namespace Controles;

internal class Controle
{
    public delegate bool DelegateDesligaMaquinas();

    private static DelegateDesligaMaquinas? delDesligaMaquinas;

    public static void Adiciona(DelegateDesligaMaquinas maquina)
    {
        delDesligaMaquinas += maquina;
    }

    public static void Remove(DelegateDesligaMaquinas maquina)
    {
        delDesligaMaquinas -= maquina;
    }

    public static void Desligar()
    {
        delDesligaMaquinas();
    }
}