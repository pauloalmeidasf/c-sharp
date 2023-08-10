namespace Classes;

internal class Email
{

    public void Enviar(string destino, string titulo, string assunto)
    {

        Console.WriteLine($"Destino: {destino}\nTítulo: {titulo}\nAssunto: {assunto}");

    }

}