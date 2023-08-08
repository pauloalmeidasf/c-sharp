using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes;

internal class Saudacao
{

    public void ExibirSaudacao()
    {

        Console.WriteLine($"Olá, hoje é {ObterDataHoraAtual():g}");

    }

    private DateTime ObterDataHoraAtual()
    {

        return DateTime.Now;

    }

}

