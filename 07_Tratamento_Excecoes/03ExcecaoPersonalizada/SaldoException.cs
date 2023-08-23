namespace Classes;

internal class SaldoException : Exception
{

    public SaldoException() : base() {}

    public override string Message => "Saldo insuficiente";

    //public override string Message
    //{ 
    //    get
    //    {
    //        return "Saldo insuficiente";
    //    }
    //}

}