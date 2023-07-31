/*
 * Tipo Char
 * Armazenado na memória Stack
 * Tipo: Valor
 * Referência 01: https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/builtin-types/char
 * Referência 02: https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/builtin-types/value-types
 * Referência 03: https://www.tamasoft.co.jp/en/general-info/unicode.html
 * 
 */

//char. System.Char (16 bits)
char letra = 'a';

Console.WriteLine("Char definido: " + letra);
Console.WriteLine();

char LetraMUnicode = '\u004D';

Console.WriteLine("Char definido com Unicode: " + LetraMUnicode);
Console.WriteLine();

Console.WriteLine("Pressione enter para finalizar...");

Console.ReadKey();