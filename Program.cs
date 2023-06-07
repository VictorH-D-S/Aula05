using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05Condicoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            string resp;

            Console.WriteLine("Bem Vindo ao -> DETRAN <-");
            Console.WriteLine("Digite sua IDADE: ");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Você tem {idade} anos.\n");

            if (idade >= 18)
            {

                Console.WriteLine("\n Você já tem CNH? Digite sim ou não: ");
                resp = Console.ReadLine();

                if (resp == "não")
                {
                    Console.WriteLine("Você está tirando sua primeira CNH.");
                }

                if (resp == "sim")
                {
                    Console.WriteLine("Renove, renove sua CNH!");
                }

            }
            else
            {
                

                Console.WriteLine($"Volte em {18 - idade} anos...");

            }


            
            Console.ReadKey();
        }
    }
}
