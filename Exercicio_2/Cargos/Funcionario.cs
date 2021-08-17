using System;

namespace Exercicio_2
{
    public abstract class Funcionario
    {
        public string Nome {get; set;}
        public double Salario {get; protected set;}
        public string TipoTrabalho {get; protected set;}
        public string Cargo {get; protected set;}
        public Funcionario(string nome, string tipoTrabalho, string cargo)
        {
            Nome = nome;
            TipoTrabalho = tipoTrabalho;
            Cargo = cargo;
        }

        public abstract void ImprimirDadosFunc();

        public abstract void InformarTipoTrabalho();

        
    }
}