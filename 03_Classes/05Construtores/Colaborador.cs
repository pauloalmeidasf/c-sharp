namespace Classes
{

    /*
     * Construtores
     * 
     * São tipos especiais de métodos usados para criar e inicializar objetos de uma classe
     * 
     * O construto possui o mesmo nome da classe e não possui nenhum tipo de retorno
     * 
     * Toda classe possui um construtor padrão
     * 
     * Sempre que uma classe é instanciada por meio da palavra-chave new, o construtor padrão é chamado
     * automaticamente
     * 
     * Uma vez que um construtor personalizado seja definido, o construtor padrão não será chamado
     * automaticamente
     * 
     */

    internal class Colaborador
    {

        private string? Nome;
        private string? Cargo;
        private int  Idade;

       // construtor padrão

       public Colaborador() { }

        //Sobrecarga de construtores

        public Colaborador(string nome)
        {

            Nome = nome;

        }

        //public Colaborador(string nome, string cargo, int idade)
        //{

        //    Nome = nome;
        //    Cargo = cargo;
        //    Idade = idade;

        //}

        public Colaborador(string nome, string cargo, int idade) : this(nome)
        {

            Cargo = cargo;
            Idade = idade;

        }

        public void Imprimir()
        {

            Console.WriteLine($"Nome: {Nome}\nCargo: {Cargo}\nIdade: {Idade}");

            Console.WriteLine();

        }

    }
}
