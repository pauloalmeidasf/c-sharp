/*
 * 
 * Conversão de Tipos
 * 
 * Referência: https://learn.microsoft.com/pt-br/dotnet/csharp/programming-guide/types/casting-and-type-conversions
 * 
 */

/*
 * Conversão implícita
 * 
 * Converte automaticamente tipo menor para um tipo maior
 * 
 * Referência: https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/builtin-types/numeric-conversions#implicit-numeric-conversions
 * 
 */

using System.Net.WebSockets;

Console.WriteLine("Conversão de tipos");
Console.WriteLine();

Console.WriteLine("Conversão Implícita");
Console.WriteLine();

int numeroInt = 2147000000;
long numeroLong = numeroInt; //int: 4 bytes; long: 8 bytes
float numeroFloat = numeroInt;
double numeroDouble = numeroInt;
decimal numeroDecimal = numeroInt;

Console.WriteLine($"Conversão de  {numeroInt} (int) para double: {numeroDouble}");
Console.WriteLine();

/*
 * Conversão Explícita
 * 
 * Converte manualmente tipo maior para um tipo menor
 * 
 * Poderá haver perda de dados ou falha ao realizar a conversão
 * 
 * Referência: https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/builtin-types/numeric-conversions#explicit-numeric-conversions
 * 
 */

Console.WriteLine("Conversão Explícita");
Console.WriteLine();

double varDouble = 12.778; //double: 8 bytes
int varInt = (int) varDouble;  //int: 4 bytes

Console.WriteLine($"Conversão de {varDouble} (double) para int: {varInt}");
Console.WriteLine();

//Resultado calculado com base nos tipos de dados

int numerador = 10;
int denominador = 4;

double resultado = (double) numerador / (double) denominador;

Console.WriteLine($"Resultado da divisão entre {numerador}/{denominador}: {resultado}");
Console.WriteLine();

//Método ToString()

Console.WriteLine("Conversão utilizando o método ToString()");
Console.WriteLine();

int valorInt = 765;
double valorDouble = 21.15;
decimal valorDecimal = 17.235969m;

string stringInt = valorInt.ToString();
string stringDouble = valorDouble.ToString();
string stringDecimal = valorDecimal.ToString();

Console.WriteLine($"int {valorInt} convertido em string: {stringInt}");
Console.WriteLine($"double {valorDouble} convertido em string: {stringDouble}");
Console.WriteLine($"decimal {valorDecimal} convertido em string: {stringDecimal}");
Console.WriteLine();

//Classe Convert

Console.WriteLine("Conversão utilizando os métodos da classe Convert");
Console.WriteLine();

int i = 10;
double d = 12.51;
bool b = true;
bool e = false;

Console.WriteLine($"Converte {i} (int) para string: {Convert.ToString(i)}");
Console.WriteLine($"Converte {i} (int) para double: {Convert.ToDouble(i)}");
Console.WriteLine($"Converte {d} (double) para int: {Convert.ToInt32(d)}");
Console.WriteLine($"Converte {b} (bool) para string: {Convert.ToString(b)}");
Console.WriteLine($"Converte {b} (bool) para int: {Convert.ToInt32(b)}");
Console.WriteLine($"Converte {e} (bool) para int: {Convert.ToInt32(e)}");

Console.WriteLine();

//OverflowException

Console.WriteLine("OverflowException");
Console.WriteLine();

int valorTemperatura = 100; //int: 32 bits (4 bytes)

byte valorTemperaturaByte = Convert.ToByte(valorTemperatura); //byte: 8 bits (1 byte)

Console.WriteLine($"Temperatura em byte: {valorTemperaturaByte}"); //byte: 0 a 255
Console.WriteLine();

Console.ReadKey();