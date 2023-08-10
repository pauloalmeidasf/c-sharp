using Classes;

Console.WriteLine("Parâmetros Opcionais");
Console.WriteLine();

var email = new Email();

email.Enviar();
Console.WriteLine();

var destinatarioEmail = "contato@empresa.com";
var tituloEmail = "Orçamento Projeto 151678";
var assuntoEmail = "Segue proposta para análise...";

email.Enviar(destinatarioEmail);
Console.WriteLine();

email.Enviar(destinatarioEmail, tituloEmail);
Console.WriteLine();

email.Enviar(destinatarioEmail, tituloEmail, assuntoEmail);
Console.WriteLine();

email.Enviar(destinatarioEmail, assunto: assuntoEmail);
Console.WriteLine();

Console.Write("Pressione enter para finalizar...");

Console.ReadKey();