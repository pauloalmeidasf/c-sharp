/*
 * Tipos Numéricos Integrais
 * 
 * Armazenados na memória Stack
 * Tipo: Valor
 * 
 * Referência 01: https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/builtin-types/integral-numeric-types
 * 
 * Referência 02: https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/builtin-types/value-types
 * 
 */

Console.WriteLine("Tipos numéricos integrais.");
Console.WriteLine();

//byte: 0 a 255. System.Byte (8 bits)
byte valor1 = 255;

//sbyte: -128 a 127. System.SByte (8 bits)
sbyte temperatura = -10;

//short: -32.768 a 32.767. System.Int16 (16 bits)
short valor3 = 7500;

//int: -2.147.483.648 a 2.147.483.647. System.Int32 (32 bits)
int valor4 = -2147483648;

//uint: 0 a 4.294.967.295. System.UInt32 (32 bits)
uint valor5 = 4294967295;

//long: -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807. System.Int64 (64 bits)
long valor6 = -9223372036854775808;

//ulong: 0 a 18.446.744.073.709.551.615. System.UInt64 (64 bits)
ulong valor7 = 0;

//Altera o valor da variável
valor7 = 18446744073709551615;

//Declara uma constante
const int PESO = 100;

//Declara variáveis de mesmo tipo em uma única linha
int var1 = 10, var2 = 5, var3 = 100, var4 = 50;

Console.WriteLine("Temperatura: " + temperatura);
Console.WriteLine();

Console.WriteLine("Pressione enter para finalizar...");
Console.ReadKey();