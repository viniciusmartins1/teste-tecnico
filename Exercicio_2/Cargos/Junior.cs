using System;

namespace Exercicio_2.Cargos
{
    public class Junior : Funcionario
    {
        public Junior(string nome) : base(nome, "Presencial", "Junior")
        {
            Salario = 1200;
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