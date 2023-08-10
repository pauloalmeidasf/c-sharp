using Classes;

Console.WriteLine("Campos Estáticos");
Console.WriteLine();

var cp1 = new ContaPoupanca();

cp1.conta = 178678;
cp1.nome = "Gabriela";

var cp2 = new ContaPoupanca();

cp2.conta = 985612;
cp2.nome = "Susana";

//atribui valor ao campo estático
ContaPoupanca.juros = 0.006m;

Console.WriteLine($"Cliente: {cp1.nome}\nNúmero Conta: {cp1.conta}\nJuros Anuais: {cp1.JurosAnuais():p}");
Console.WriteLine();

Console.WriteLine($"Cliente: {cp2.nome}\nNúmero Conta: {cp2.conta}\nJuros Anuais: {cp2.JurosAnuais():p}");
Console.WriteLine();

Console.Write($"Pressione qualquer tecla para finalizar...");

Console.ReadKey();