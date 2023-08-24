namespace Maquinas;
internal abstract class Maquina
{
    public abstract bool Ligada { get; set; }
    public abstract bool Desligar();
}