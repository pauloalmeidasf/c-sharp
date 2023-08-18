using Interfaces;

namespace Classes;

//Classe Quadrado "herda ou estende" a Classe Forma
//Classe Quadrado "implementa" as Interfaces IControle e IForma
internal class Quadrado : Forma, IControle, IForma
{

}
