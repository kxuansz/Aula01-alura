using aula01;
using System;
using System.ComponentModel.Design;

class MainProgram
{         
     //Main execute the program media
        static void Main(string[] args) {
        Console.Write("Digite o programa que deseja executar: ");
        var execute = Console.ReadLine();
        Console.WriteLine("------------------------------");

        if (execute == "Media" | execute == "media")
        {
            Console.WriteLine("Executando o programa de média");
            Console.WriteLine("------------------------------");
            Media.Run();
        }

        else if (execute == "List" | execute == "list")
        {
            Console.WriteLine("Executando o programa de lista");
            Console.WriteLine("------------------------------");
            List.Run();
        }
        else if (execute == "Value" | execute == "value")
        {
            Console.WriteLine("Executando o programa Hello World");
            Console.WriteLine("------------------------------");
            nValue.Run();
        }

        else
        {
            Console.WriteLine("Programa não encontrado");
        }
    }
}