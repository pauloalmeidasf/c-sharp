/*
 * Tipo Object
 * 
 * É o tipo base para todos os outros tipos
 * Utilizado quando não é conhecido o tipo de dado que deverá ser utilizado
 * 
 * Tipo: Referência
 * Armazenado na memória Heap
 * Valor padrão: null
 * 
 * Referência: https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/builtin-types/reference-types#the-object-type
 * 
 */

/*
 * Tipo Dynamic
 * 
 * Na maioria dos casos se comporta como tivesse o tipo object
 * 
 * Se o código não for válido, os erros ocorrerão em tempo de execução
 * 
 * Tipo: Referência
 * Armazenado na memória Heap
 * Valor padrão: null
 * 
 * Referência: https://learn.microsoft.com/pt-br/dotnet/csharp/advanced-topics/interop/using-type-dynamic
 * 
 */

//object

Console.WriteLine("Tipo object");
Console.WriteLine();

object nota = 10;
object valor = 900.55m;
object nome = "Pedro";
object ativo = true;
object letra = 'A';
object padraoObject = null;

//object testeObject = true;
//testeObject = false;
//testeObject = "12345";
//Console.WriteLine("Teste realizado com object: " + testeObject);
//Console.WriteLine();

Console.WriteLine("Nota: " + nota);
Console.WriteLine("Valor: " + valor);
Console.WriteLine("Nome: " + nome);
Console.WriteLine("Ativo: " + ativo);
Console.WriteLine("Letra: " + letra);
Console.WriteLine("Valor Padrão Object: " + padraoObject);

Console.WriteLine();

//dynamic

Console.WriteLine("Tipo Dynamic");
Console.WriteLine();

dynamic notaAluno = 9;
dynamic valorPedido = 3055.93m;
dynamic nomeColaborador = "Sofia";
dynamic contaAtiva = false;
dynamic letraP = 'P';
dynamic padraoDinamic = null;

//dynamic testeDynamic = false;
//testeDynamic = true;
//testeDynamic = "1245";
//Console.WriteLine("Teste realizado com dynamic: " + testeDynamic);
//Console.WriteLine();

Console.WriteLine("Nota Aluno: " + notaAluno);
Console.WriteLine("Valor Pedido: " + valorPedido);
Console.WriteLine("Nome Colaborador: " + nomeColaborador);
Console.WriteLine("Conta Ativa: " + contaAtiva);
Console.WriteLine("Letra P: " + letraP);
Console.WriteLine("Valor Padrão Dynamic: " + padraoDinamic);

Console.WriteLine();

Console.WriteLine("Pressione uma tecla para finalizar...");

Console.ReadKey();