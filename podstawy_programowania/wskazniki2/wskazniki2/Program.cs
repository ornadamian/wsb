using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wskazniki2
{
    public struct Punkt
    {
        public int x;
        public int y;

    }
    class Program
    {
        
        unsafe static void Swap(int*a,int*b)
        {
            int temp = *a;
            *a = *b;
            *b = temp;
        }
        unsafe static void Main(string[] args)
        {

            int a = 2;
            int b = 3;
            Console.WriteLine("a= {0}\nb = {1}",a,b);
            Swap(&a, &b);
            Console.WriteLine("a= {0}\nb = {1}", a, b);


            int c = 100;
            int d = 200;

            int* c1 = &c;
            int* d1 = &d;

            Console.WriteLine("\nWartości przed zmienną c = {0}, d= {1)", c,d);
            Swap(c1, d1);
            Console.WriteLine("\nWartości przed zmienną c = {0}, d= {1)", c, d);
            Console.ReadKey();
        }
    }
}
