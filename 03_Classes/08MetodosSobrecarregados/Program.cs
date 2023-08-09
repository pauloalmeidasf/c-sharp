using Classes;

Console.WriteLine("Sobrecarga de métodos");
Console.WriteLine();

var email = new Email();

email.Enviar("contato@empresa.com.br");
email.Enviar("contato@empresa.com.br","Proposta de Venda");
email.Enviar("contato@empresa.com.br","Proposta de Venda",650000);

Console.WriteLine("Pressione qualquer tecla para finalizar...");

Console.ReadKey();