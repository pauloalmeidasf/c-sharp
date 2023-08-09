namespace Classes;

/*
 * Sobrecarga de métodos
 * 
 * Assinatura de um método:
 * 
 * 1. Nome do método
 * 2. Número de parâmetros
 * 3. Tipos dos parâmetros
 * 4. Ordem dos parâmetros
 * 
 * Não é possível existir 2 métodos com a mesma assinatura
 * 
 * Observação: o tipo de retorno não faz parte da assinatura do método
 * 
 */

internal class Email
{

    public void Enviar(string endereco)
    {

        Console.WriteLine($"Endereço: {endereco}");
        Console.WriteLine();

    }

    public void Enviar(string endereco, string assunto)
    {

        Console.WriteLine($"Endereço: {endereco}");
        Console.WriteLine($"Assunto: {assunto}");
        Console.WriteLine();

    }

    public void Enviar(string endereco, string assunto, decimal valor)
    {

        Console.WriteLine($"Endereço: {endereco}");
        Console.WriteLine($"Assunto: {assunto}");
        Console.WriteLine($"Valor Proposta: {valor:c}");

        Console.WriteLine();

    }

}
