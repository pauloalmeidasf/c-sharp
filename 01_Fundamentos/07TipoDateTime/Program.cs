/*
 * DateTime (Struct)
 * 
 * Representa data e hora
 * 
 * Tipo: Valor
 * Armazendo na memória Stack
 * 
 * Valor padrão: 01/01/0001 00:00:00
 * 
 * Referência: https://learn.microsoft.com/pt-br/dotnet/api/system.datetime?view=net-7.0
 * 
 */

using System.Globalization;

Console.WriteLine("Tipo DateTime");
Console.WriteLine();

//Define data com o padrão yyyy-MM-dd
DateTime dataEvento = new DateTime(2023,07,31);

Console.WriteLine("Data do evento: " + dataEvento.ToShortDateString());
Console.WriteLine();

//Define data com o padrão yyyy-MM-dd HH:mm:ss
DateTime dataHoraAula = new DateTime(2023, 07, 31, 07, 15, 00);

Console.WriteLine("Data Hora da Aula: " + dataHoraAula);
Console.WriteLine();

Console.WriteLine("Operações com data e hora");
Console.WriteLine();

DateTime dataAtual = DateTime.Now;

Console.WriteLine("Data e hora atuais: " + dataAtual);
Console.WriteLine("Ano: " + dataAtual.Year);
Console.WriteLine("Mês: " + dataAtual.Month);
Console.WriteLine("Dia: " + dataAtual.Day);
Console.WriteLine("Horas: " + dataAtual.Hour);
Console.WriteLine("Minutos: " + dataAtual.Minute);
Console.WriteLine("Segundos: " + dataAtual.Second);
Console.WriteLine("Milissegundos: " + dataAtual.Millisecond);

Console.WriteLine();

//adicionar valores

Console.WriteLine("Data Hora atuais + 30 dias: " + dataAtual.AddDays(30));
Console.WriteLine("Data Hora atuais + 45 horas: " + dataAtual.AddHours(45));
Console.WriteLine("Data Hora atuais + 2 meses: " + dataAtual.AddMonths(2));
Console.WriteLine("Data Hora atuais + 5 anos: " + dataAtual.AddYears(5));

Console.WriteLine();

//obter dia da semana e do ano

Console.WriteLine("Dia da semana: " + dataAtual.DayOfWeek); //mostra na cultura inglesa
Console.WriteLine("Dia da semana: " + dataAtual.ToString("dddd")); //mostra na cultura local do dispositivo
Console.WriteLine("Dia do ano: " + dataAtual.DayOfYear);

Console.WriteLine();

//exibir data nos formatos longo e abreviado
Console.WriteLine("Data Extensa: " + dataAtual.ToLongDateString());
Console.WriteLine("Data Abreviada: " + dataAtual.ToShortDateString());

Console.WriteLine();

//exibir hora nos formatos longo e abreviado
Console.WriteLine("Hora Extensa: " + dataAtual.ToLongTimeString());
Console.WriteLine("Hora Abreviada: " + dataAtual.ToShortTimeString());

Console.WriteLine();

Console.WriteLine("Pressione qualquer tecla para finalizar...");

Console.ReadKey();