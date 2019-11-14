using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funkcje2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Napisz funkcję która wyświetli sumę cyfr w liczbie
            */
            Console.WriteLine(sum(12345));

            int x = 10;
            int y = 9;

            Console.WriteLine(checkEven(x));
            Console.WriteLine(checkEven(y));

            /*
            * napisz program, który wyświetli czy liczba jest parzysta/nieparzysta
            * Funkcja zwraca string (liczba parzysta lub liczba nieparzsyta)
            */

            Console.ReadKey();
        }
        static string checkEven(int x)
        {
            if (x % 2 == 0)
            {
                return "liczba parzysta";
            }
            else
            {
                return "liczba parzysta";
            }
        }

        static int sum(int x, int sum = 0)
        {
            do
            {
                sum = sum + x % 10;
                x /= 10;

            } while (x != 0);

            return sum;

        }
    }
}
