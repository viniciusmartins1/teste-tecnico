using System;

namespace Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorMoto;
            string opcaoPagar;
            double precoFinal;


            Console.WriteLine("Digite o valor da moto: ");
            valorMoto = double.Parse(Console.ReadLine());

            Console.WriteLine("Como vai pagar? ");
            Console.WriteLine("1 - a vista");
            Console.WriteLine("2 - 5 parcelas");
            Console.WriteLine("3 - 11 parcelas");
            Console.WriteLine("4 - 17 parcelas");
            Console.WriteLine("5 - 23 parcelas");
            Console.WriteLine("6 - 29 parcelas");
            opcaoPagar = Console.ReadLine();

            if(opcaoPagar == "1")
            {
                precoFinal = valorMoto - (valorMoto * 0.3);
                Console.WriteLine("O preço final ficou {0}", precoFinal);
            }
            else
            {
                switch (opcaoPagar)
                {
                    case "2":
                        precoFinal=valorMoto + (valorMoto * 1.004);
                        Console.WriteLine("O preço final ficou {0}", precoFinal);
                        break;
                    case "3":
                        precoFinal=valorMoto + (valorMoto * 1.007);
                        Console.WriteLine("O preço final ficou {0}", precoFinal);
                        break;
                    case "4":
                        precoFinal=valorMoto + (valorMoto * 1.01);
                        Console.WriteLine("O preço final ficou {0}", precoFinal);
                        break;
                    case "5":
                        precoFinal=valorMoto + (valorMoto * 1.013);
                        Console.WriteLine("O preço final ficou {0}", precoFinal);
                        break;
                    case "6":
                        precoFinal=valorMoto + (valorMoto * 1.016);
                        Console.WriteLine("O preço final ficou {0}", precoFinal);
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
            }






        }
    }
}
