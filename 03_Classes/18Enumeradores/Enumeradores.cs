namespace Enumeradores;

/*
 * 
 * Enum
 * 
 * Um tipo de enumeração
 * 
 * É um tipo de valor definido por um conjunto de constantes nomeadas do tipo numérico integral
 * 
 * Referência: https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/builtin-types/enum
 * 
 */

//enum pode ser de qualquer tipo de dados numéricos integrais; o padrão é int
enum Categorias
{
    Eletrônico,            //0
    Eletrodoméstico,   //1
    Brinquedo,            //2
    Livro                     //3
}

enum DiasSemana : int
{
    Domingo = 1,
    Segunda = 2,
    Terça = 3,
    Quarta = 4,
    Quinta = 5,
    Sexta = 6,
    Sábado = 7
}

enum RGB : byte
{
    Red,
    Green,
    Blue
}