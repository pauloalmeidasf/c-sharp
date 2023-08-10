using Classes;

Console.WriteLine("Argumentos nomeados");
Console.WriteLine();

var email = new Email();

//argumentos sendo informados na ordem dos parâmetros do método
email.Enviar("contato@empresa.com.br", "Reunião Discussão Orçamentária", "Reunião com Diretoria para...");
Console.WriteLine();

//argumentos nomeados
email.Enviar(titulo:"Reunião Discussão Orçamentária",destino: "contato@empresa.com.br", 
    assunto: "Reunião com Diretoria para...");

Console.WriteLine();

Console.Write("Pressione qualquer tecla para finalizar...");

Console.ReadKey();