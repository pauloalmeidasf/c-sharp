namespace Maquinas;
internal class MaquinaSolda : Maquina
{
    public override bool Ligada { get; set; } = true;
    public override bool Desligar()
    {
        return Ligada = false;
    }
}