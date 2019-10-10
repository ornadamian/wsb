using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instrukcje_warunkowe
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x = 5;
            if (x > 3)
            {
                Console.WriteLine("Prawda");

            }
            else if(x ==5 )
                {
                Console.WriteLine("x jest równy 5");
            }

            else
            {
                Console.WriteLine("inna");
                
            }
            */
            
            Console.WriteLine("Podaj podstawę trójkąta");
            string podstawa = Console.ReadLine();
            Console.WriteLine("Podaj wysokość trójkąta");
            string wysokosc = Console.ReadLine();

            //double x1 = double.Parse(x);

            double podstawa1, wysokosc1, pole;

            if (double.TryParse(podstawa, out podstawa1) &&
                double.TryParse(wysokosc, out wysokosc1))
            
            {
                //oblicznaie pola trójkąta
               
                pole = 0.5 * podstawa1 * wysokosc1;
                Console.WriteLine("Pole wynosi:\n" + pole);
            }
            else
            {
                Console.WriteLine("Error Błędne dane!!!");                
            }
            

            
            Console.ReadKey();
        }

    }

}
