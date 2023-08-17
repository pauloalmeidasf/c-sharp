namespace Classes;

internal class Base
{

    //virtual: permite que o método M1 seja sobrescrito na classe Derivada1
    public virtual void M1() => Console.WriteLine("Método M1 - Classe Base");

    //virtual: permite que o método M2 seja sobrescrito na classe Derivada1
    public virtual void M2() => Console.WriteLine("Método M2 - Classe Base"); 

}

internal class Derivada1 : Base
{

    //override: sobrescreve o método M1 da classe Base
    public override void M1() => Console.WriteLine("Método M1 - Classe Derivada1");

    //sealed: impede que o método M2 seja sobrescrito na classe derivada
    //override: sobrescreve o método M2 da classe Base
    public sealed override void M2() => Console.WriteLine("Método M2 - Classe Derivada1");

}

internal class Derivada2 : Derivada1
{

    public override void M1() => Console.WriteLine("Método M1 - Classe Derivada2");

    //Erro:
    //public override void M2() => Console.WriteLine("Método M1 - Classe Derivada2");

}