/*
 * Nullable Types (Tipos anuláveis)
 * 
 * Uma variável de tipo-valor (int, double, char, bool, etc) não pode conter o valor null
 * 
 * Nullable Types permitem atribuir um valor null a um tipo-valor
 * 
 * Null: valor ausente ou indefinido
 * 
 * https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/builtin-types/nullable-value-types
 * 
 */

Console.WriteLine("Nullable Types");
Console.WriteLine();

//não é possível atribuir null a um tipo-valor; exemplo:  int

//int valor = null;

//Declarar Nullable Types
Nullable<int> a = null;
Nullable<int> b = 100;
Nullable<double> c = 100.9;
Nullable<double> d = null;
Nullable<bool> e = false;
Nullable<bool> f = null;

//Declarar Nullable Types - Alternativa

int? varA = null;
int? varB = 100;
double? varC = null;
double? varD = 50.954;
bool? varE = false;
bool? varF= null;

Console.WriteLine("Valor de varA: " + varA);
Console.WriteLine("Valor de varB: " + varB);
Console.WriteLine("Valor de varC: " + varC);
Console.WriteLine("Valor de varD: " + varD);
Console.WriteLine("Valor de varE: " + varE);
Console.WriteLine("Valor de varF: " + varF);

Console.WriteLine();

//não é possível atribui uma variável de tipo anulável em uma variável de tipo-valor

//int? h = null;
//int i = h;



/*
 * Coalescência Nula (??)
 * 
 * int? h = null
 * int i = h ?? -1
 * 
 * Se o valor de 'h' for diferente de null, i receberá o valor do operando esquerdo do operador ??
 * Se o valor de 'h' for igual a null, i receberá o valor do operando direito do operador ??
 * 
 */

Console.WriteLine("Coalescência Nula");
Console.WriteLine();

int? h = null;
int i = h ?? -1;

Console.WriteLine("Valor da variável 'i': " + i);

//exemplo de coalescência nula usando string (tipo-referência)

string curso = "Curso de CSharp - IMPACTA";
string resposta = curso ?? "Não informado";

Console.WriteLine("Nome do curso: " + resposta);
Console.WriteLine();

//Coalescência Nula - Operadores

Console.WriteLine("Coalescência Nula - Operadores");
Console.WriteLine();

//int? valorA = 4;
//int valorB = 3;
//int valorC = valorA * valorB;

//int? valorA = 4;
//int? valorB = 3;
//int valorC = valorA * valorB;

int? valorA = 4;
int? valorB = 3;
int? valorC = valorA * valorB;

Console.WriteLine("Valor da variável 'valorC': " + valorC);
Console.WriteLine();

Console.WriteLine("Pressione qualque tecla para finalizar...");
Console.ReadKey();