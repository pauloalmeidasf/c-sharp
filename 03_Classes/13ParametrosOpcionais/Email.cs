namespace Classes;
internal class Email
{

    public void Enviar(string destino = "Não Informado", string titulo = "Não Informado", string assunto = "Não Informado")
    {

        Console.WriteLine($"Destino: {destino}\nTítulo: {titulo}\nAssunto: {assunto}");

    }

}
