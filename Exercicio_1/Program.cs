using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string vacina;
            DateTime data;

            Console.WriteLine("-----Controle de Vacina-----");
            Console.WriteLine("Qual vacina você tomou?");

            Console.WriteLine("1 - Coronavac");
            Console.WriteLine("2 - Janssen");
            vacina = Console.ReadLine();

            Console.WriteLine("Informe a data da primeira dose! Ex: 01/01/2021");
            data = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            if(vacina == "2")
            {
                Console.WriteLine("Vacina: Janssen");
                Console.WriteLine("Data da primeira dose: {0}", data.ToString("dd/MM/yyyy"));
                Console.WriteLine("Dose Única, não precisa de segunda dose!");
            }
            else
            {
                Console.WriteLine("Vacina: Coronavac");
                Console.WriteLine("Data da primeira dose: {0}", data.ToString("dd/MM/yyyy"));
                Console.WriteLine("Data da segunda dose: {0}", data.AddDays(14).ToString("dd/MM/yyyy"));
            }

        }
    }
}
