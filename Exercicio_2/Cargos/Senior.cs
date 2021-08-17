using System;

namespace Exercicio_2.Cargos
{
    public class Senior : Funcionario
    {
        public Senior(string nome ) : base(nome, "Híbrido", "Sênior")
        {
            Salario = 4000;
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