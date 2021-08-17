using System;
using Exercicio_2.Cargos;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ImprirDadosTeste();
        }
        
        public static void ImprirDadosTeste()
        {
            Funcionario vinicius = new Estagiario("Vinicius");
            vinicius.ImprimirDadosFunc();
            vinicius.InformarTipoTrabalho();
            Console.WriteLine();

            Funcionario pedro = new Junior("Pedro");
            pedro.ImprimirDadosFunc();
            pedro.InformarTipoTrabalho();
            Console.WriteLine();

            Funcionario maria = new Senior("Maria");
            maria.ImprimirDadosFunc();
            maria.InformarTipoTrabalho();
            Console.WriteLine();
        }
    }
}
