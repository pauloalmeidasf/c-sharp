/*
 * Modificadores de acesso
 * 
 * membro public: não existe nenhuma restrição de acesso dentro e fora do assembly
 * membro protected: o acesso é limitado à classe que o define e às classes derivadas
 * membro private: o acesso é limitado à classe de definição
 * 
 * internal: o acesso é limitado ao assembly atual
 * 
 * Referência: https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/access-modifiers
 * 
 */

using Classes;

Console.WriteLine("Modificadores de Acesso");
Console.WriteLine();

Base.MetodoPublic();

Derivada.MetodoPublic();
Derivada.TesteAcesso();

Console.WriteLine();

Console.Write("Pressione qualquer tecla para finalizar...");

Console.ReadKey();