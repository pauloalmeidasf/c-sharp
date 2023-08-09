namespace Classes
{
    internal class Aluno
    {

        private string? nome;
        private int idade;
        private string? genero;

        public void Consultar(Aluno aluno)
        {

            Console.Write($"Informe o nome: ");
            aluno.nome = Console.ReadLine();

            Console.Write($"Informe a idade: ");
            aluno.idade = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Informe o gênero: ");
            aluno.genero = Console.ReadLine();

            Imprimir();

        }

        private void Imprimir()
        {
            Console.WriteLine();

            Console.WriteLine("Dados do aluno");

            Console.WriteLine();

            Console.WriteLine($"Aluno: {nome}\nGênero: {genero}\nIdade: {idade}");

        }
    }
}
