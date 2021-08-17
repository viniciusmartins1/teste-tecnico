using System;

namespace Exercicio_2.Cargos
{
    public class Estagiario : Funcionario
    {
        public Estagiario(string nome) : base(nome, "home-office", "Estagiário")
        {
            Salario = 800;
        }

        public override void ImprimirDadosFunc()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Cargo: " + Cargo);
            Console.WriteLine("Salário: " + Salario);
        }

        public override void InformarTipoTrabalho()
        {
            Console.WriteLine("Modalidade de Trabalho: " + TipoTrabalho);
        }
    }
}