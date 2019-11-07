using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablice
{
    class Program
    {
        static void Main(string[] args)
        {

            //Typ wartościowy

            int a = 10;
            int b = a;

            a--;

            Console.WriteLine("Zmienna a: " + a);
            Console.WriteLine("Zmienna b: " + b);


            //Typ Referencyjny

            int[] tabA = { 2, 2, 2 };
            int[] tabB = tabA;


            tabA[2] = 10;
            tabB[0] = 8;

            Console.Write("Wyświetlenie tablicy A: ");
                foreach (int item in tabA)
                {
                    Console.Write(" " + item);
            }
            Console.WriteLine();



            Console.Write("Wyświetlenie tablicy B: ");
                
                foreach (int item in tabB)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();

            //kopiowanie tablic 
            int[] tab = { 1, 2, 3, 4, 5 };
            int[] tabcopy = new int[5];

            foreach(int item in tabcopy)
            {
                Console.Write(" " + item);
            }

            Console.WriteLine();

            tab.CopyTo(tabcopy, 0);

            foreach (int item in tabcopy)
            {
                Console.Write(" " + item);
            }

            //2 sposób kopiowania 

            Console.WriteLine("sdf");

            // Array.Copy(tab, tabcopy, tab.Length);

            foreach (int item in tabcopy)

            {
                Console.Write(" " + item);
            }



                Console.ReadKey();










        }
    }
}
