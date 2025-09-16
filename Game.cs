using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace aula01
{
    internal class Game
    {
        public static void Run()
        {
            int randomNumber()
            {
                Random random = new Random();
                return random.Next(1, 100);
            }

            do
            {
                randomNumber();

                Console.WriteLine("\nAdivinhe o número entre 1 e 100");
                Console.WriteLine("--------------------------------");
                int userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput < randomNumber())
                {
                    Console.WriteLine("\nO número é maior");
                    Console.WriteLine("--------------------------------");
                }
                else if (userInput > randomNumber())
                {
                    Console.WriteLine("\nO número é menor");
                    Console.WriteLine("--------------------------------");
                }
                else
                {
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("Parabéns! Você acertou o número!");
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("--------------------------------");
                    break;
                }
            }
            while (true);

        }
    }
}
