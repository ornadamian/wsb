using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wskazniki
{
    class Program
    {
        unsafe static void Main(string[] args)
        {
               char* x;
            char letter = 'x';
            x = &letter;
            letter = 'a';

            Console.WriteLine("Znak: {0}", letter);
            Console.WriteLine("Znak: {0}", *x);
            //Console.WriteLine("Adres w pamięci zmiennej letter: {0}", (int) x);
            int test = 3658;
            Console.WriteLine(Convert.ToString(test, 8));

            double number;
            double* numberAdress;
            number = 10;
            numberAdress = &number;

            Console.WriteLine("Liczba wynosi: {0}", number);
            Console.WriteLine("Liczba wynosi: {0}", numberAdress->ToString());
            Console.WriteLine("Adres zmiennej wynosi: {0}", (int)numberAdress);



            
            Console.ReadKey();
        }
        

    }
}
