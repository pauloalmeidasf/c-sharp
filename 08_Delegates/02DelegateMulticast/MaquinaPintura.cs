namespace Maquinas;
internal class MaquinaPintura : Maquina
{
    public override bool Ligada { get; set; } = true;
    public override bool Desligar()
    {
        return Ligada = false;
    }
}