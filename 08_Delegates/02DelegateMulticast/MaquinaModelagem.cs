namespace Maquinas;
internal class MaquinaModelagem : Maquina
{
    public override bool Ligada { get; set; } = true;
    public override bool Desligar()
    {
        return Ligada = false;
    }
}