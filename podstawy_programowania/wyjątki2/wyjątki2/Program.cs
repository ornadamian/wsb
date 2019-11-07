using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wyjątki2
{
    class Program
    {
        static void Main(string[] args)
        {
            uint number;
            while (true)
            {

                Console.WriteLine("Wprowadz liczbę całkowitą: ");
                string X = Console.ReadLine();
                try
                {
                    number = uint.Parse(x);
                    break;
                }

                catch (FormatException)
                {
                    Console.WriteLine("Prowadz liczbę w poprawnym formacie np. 4 \n");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Wprowadzona liczba jest poza dopuszczalnym zakresem. \n");
                    Console.WriteLine("Zakres liczb: <0;4 294 967 295 \n");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Wartość nie moze być pusta \n" );
                }
                Console.WriteLine("Wprowadz poprawnie wartość:");
                Console.ReadKey();

            }
        }
    }
}

