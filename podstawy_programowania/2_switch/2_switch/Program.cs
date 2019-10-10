using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Pole kwadratu");
            Console.WriteLine("2 - Pole koła");
            Console.WriteLine("Podaj Wartość");
            string x;
            x = Console.ReadLine();

            switch (x)
            {
                case "1":
                    {
                        Console.WriteLine("Wybrano opcję nr 1");

                        Console.Write("Podaj bok:");
                        double bok = double.Parse(Console.ReadLine());

                        if (true)
                        {
                            //poprawne dane
                            Console.WriteLine("Pole prostokąta wynosi: " + bok * bok);
                        }

                        else
                        {
                            Console.WriteLine("Podałeś błędne dane");
                        }

                        break;
                    }
                    
                case "2":
                    {
                        Console.WriteLine("Wybrano opcję nr 2");

                        Console.Write("Podaj długość promienia r:");
                        double r = double.Parse(Console.ReadLine());
                        
                        if (double.TryParse(r,out r1))
                        {
                            //poprawne dane
                            Console.WriteLine("Pole okręgu wynosi: " + Math.PI * 2 * r1);
                        }

                        else
                        {
                            Console.WriteLine("Podałeś błędne dane");
                        }

                        break;
                        
                    }
                default:
                    {
                        Console.WriteLine("Podano błęd" +
                            "ne dane");
                        break;
                    }

            }
            Console.ReadKey();
        }
    }
}
