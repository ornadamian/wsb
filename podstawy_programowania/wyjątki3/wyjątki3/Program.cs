using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wyjątki3
{
    class Program
    {
        static void Main(string[] args)
        {
            uint x = 10;
            try
            {
                Console.WriteLine("Podaj dzień tygodnia (1-5): ");
                string str = Console.ReadLine();
                x = uint.Parse(str);
            }
            catch
            {
                Console.WriteLine("Error");
            }

            finally
            {
                Console.WriteLine("x= " + x);
            }




            //#####################################################################
            switch(x)
            {
                case 1:
                    Console.WriteLine("Poniedziałek");
                    break;
                case 2:
                    Console.WriteLine("Wtorek");
                    break;
                case 3:
                    Console.WriteLine("Środa");
                    break;
                case 4:
                    Console.WriteLine("Czwartek");
                    break;
                case 5:
                    Console.WriteLine("Piątek");
                    break;
                case 6:
                    throw new System.Exception("Masz już weekend, błędne dane");
                    break;
                case 7:
                    throw new System.Exception("Niedziela");
                    break;
                default:
                    break;
            }

            /*
             * Napisz kalkulator, uwzględnij wyjątki
             * dodaj menu wyboru działania XD
             * użytkownik może zamknąć program wpisując XD
             */
             
            Console.ReadKey();
        }

    }
}
