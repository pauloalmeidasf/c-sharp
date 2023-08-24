namespace Classes;

internal class Conta
{

    public int Numero { get; private set; }
    public string? Titular { get; private set; }
    public decimal Saldo { get; private set; }

    public Conta(int numero, string titular, decimal saldo)
    {

        Numero = numero;
        Titular = titular;
        Saldo = saldo;

    }

    public void Depositar(decimal valor)
    {
        Console.WriteLine($"Depósito realizado");
        Console.WriteLine();
        Saldo += valor;
    }

    public void Sacar(decimal valor)
    {
        if (Saldo >= valor)
        {
            Console.WriteLine($"Saque realizado");
            Console.WriteLine();
            Saldo -= valor;
        }
        else
        {
            Console.WriteLine($"Saque não pode ser realizado");
            throw new SaldoException();
        }
    }

    public override string ToString()
    {
        return $"Conta: {Numero}\nTitular: {Titular}\nSaldo: {Saldo}";
    }
}
