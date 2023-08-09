namespace Classes
{
    internal class Velocidade
    {

        public int valor1;
        public int valor2;

        private void DadosVelocidade(Velocidade v)
        {

            Console.WriteLine($"Classe: {this}");
            Console.WriteLine($"Valor de V1: {valor1}");
            Console.WriteLine($"Valor de V2: {valor2}");

        }

        public void ExibirVelocidade()
        {

            DadosVelocidade(this);

        }

    }
}
