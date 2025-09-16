using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula01
{
    internal class List
    {
        public static void Run()
        {
            List<string> nomes = new List<string>();
            nomes.Add("JavaScript");
            nomes.Add("C#");
            nomes.Add("PHP");

            Console.WriteLine("Tente a melhor linguagem");
            string response = Console.ReadLine();

            String rightResponse = "C#";

            if (response != rightResponse)
            {
                Console.WriteLine("Errado, tente novamente");
            }
            else
            {
                Console.WriteLine("Parabéns, você acertou");
            }


        }
    }
}
