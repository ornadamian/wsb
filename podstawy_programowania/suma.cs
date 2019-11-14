using System;
// using Second_Name;
// using Outer.Middle.Inner;

namespace ConsoleApp1
{
    class Program
    {
        //static void Main(string[] args)
        //{

        //}




        static void Main(string[] args)
        {
            int[] tab = new int[2];
            tab[0] = 5;
            tab[1] = 10;
            Console.WriteLine("Wartość tablicy przed wywołaniem funkcji: {0} i {1}", tab[0], tab[1]);
            tab1(ref tab);
            Console.WriteLine("Wartość tablicy po wywołaniu funkcji: {0} i {1}", tab[0], tab[1]);

            tabtab(tab);

            Console.ReadKey();
        }

        static void tabtab(int[] tab)
        {
            Console.Write("Elementy funckji:  ");
            foreach (int x in tab)
            {
                Console.Write(x + " ");
            }
        }

        static void tab1( ref int[] tab)
        {
            tab = new int[2];
            tab[0] = -1;
            tab[1] = -5;
        }




    }
}
