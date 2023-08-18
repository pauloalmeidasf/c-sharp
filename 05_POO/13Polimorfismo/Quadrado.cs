namespace Classes;

//Classe Quadrado "herda ou estende" Figura
internal class Quadrado : Figura
{

    public override string Imprimir()
    {

        return $"{base.Imprimir()}Quadrado";

    }

}
