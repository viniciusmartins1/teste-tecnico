using System;

namespace Exercicio_2
{
    public class Funcionario
    {
        private string _nome;
        public string Nome { 
            get
            {
                return _nome;
            } 
            set
            {
                _nome = value;
            } 
            }
        private string _cargo;
        public string Cargo { 
            get
            {
                return _cargo;
            } 
            set
            {
                if(value != "Estagiário" || value != "Junior" || value != "Sênior" )
                {
                    Console.WriteLine("ERROR: Cargo inválido!");
                    return;
                }

                _cargo = value;
            } 
            }
        private double _salario;
        public double Salario { 
            get
            {
                return _salario;
            } 
            private set
            {
                _salario = value;
            }}

        public Funcionario(string nome, string cargo)
        {
            Nome = nome;
            Cargo = cargo;

            switch(Cargo)
            {
                case "Estagiário":
                    Salario = 800.00;
                    break;
                case "Junior":
                    Salario = 1200.00;
                    break;
                case "Sênior":
                    Salario = 2500.00;
                    break;
                default:
                    break;
            }
        }

        public void ImprimirDadosFunc()
        {
            Console.WriteLine("Nome: {0}", _nome);
            Console.WriteLine("Cargo: {0}", _cargo);
            Console.WriteLine("Salário: {0}", _salario);
        }

        public void InformarTipoTrabalho()
        {
            switch (_cargo)
            {
                case "Estagiário":
                    Console.WriteLine("home office");
                    break;
                case "Junior":
                    Console.WriteLine("Presencial");
                    break;
                case "Sênior":
                    Console.WriteLine("Híbrido");
                    break;
                default:
                    break;
            }
            
        }

        
    }
}