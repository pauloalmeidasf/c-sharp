namespace Classes;

/*
 * 
 * Campos Estáticos
 * 
 * São definidos utilizando o modificador static na declaração do campo
 * 
 * Pertecem à classe e não a um objeto
 * 
 * Um campo estático é compartilhado com todas as instâncias da classe
 * 
 */

internal class ContaPoupanca
{

    public int conta;
    public string? nome;
    public string? cpf;

    //declarção de um campo estático
    public static decimal juros;

    public decimal JurosAnuais()
    {

        return juros * 12;

    }

}
