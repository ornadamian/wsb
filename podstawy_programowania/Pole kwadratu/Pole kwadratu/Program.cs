using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pole_kwadratu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program oblicza pole prostokąta z podanych przez użytkownika danych");

            Console.Write("Podaj bok a:");
            double bok_a = double.Parse(Console.ReadLine());
           

            Console.Write("Podaj bok b:");
            double bok_b = double.Parse(Console.ReadLine()) ;
            


            Console.WriteLine("Pole prostokąta wynosi: " + bok_a * bok_b);

            Console.ReadKey();
        }
    }
}
