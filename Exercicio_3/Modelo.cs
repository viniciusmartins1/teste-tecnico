using System;

namespace Exercicio_3
{
    public class Modelo
    {
        public string nome;
        public double altura;
        public double peso;
        public int idade;
        private string trabalho;

        public Modelo()
        {
            trabalho = "Malhação";
        }
        public void MostrarDados()
        {
            Console.WriteLine(this.nome);
            Console.WriteLine(this.trabalho);
        }


    }
}