using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wyjątki
{
    class Program
    {
        static void Main(string[] args)
        {

            uint number;
            while (true)
            {
                Console.Write("Wprowadz Liczbę całkowitą: ");
                string x = Console.ReadLine();

                try
                {
                number = uint.Parse(x);
                break;
                }


                     catch (SystemException e)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Podałeś błędne dane: " + x + "\n");
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Prawidłowe dane: " + number);  

            Console.ReadKey();

        }
    }
}
