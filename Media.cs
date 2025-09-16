using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula01
{
    internal class Media
    {
         public static void Run()
        {
            double n1, n2, n3, n4, media;

            Console.WriteLine("Digite a primeira nota: ");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota: ");
            n3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a quarta nota: ");
            n4 = Convert.ToDouble(Console.ReadLine());

            media = (n1 + n2 + n3 + n4) / 4;

            Console.WriteLine($"A média é: {media}");


            if (media >= 5)
            {
                Console.WriteLine("Aprovado");
            }
            else if (media > 4.5 || media < 5)
            {
                Console.WriteLine("Recuperação");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }

            
        }
    }
}
