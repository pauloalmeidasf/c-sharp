namespace Classes;
internal class Pedido
{
    public int Numero { get; set; }
    public decimal Valor { get; set; }
    public Pedido(int numero, decimal valor)
    {
        Numero = numero;
        Valor = valor;
    }

    public override string ToString()
    {
        return $"Pedido: {Numero}. Valor: {Valor}";
    }
}