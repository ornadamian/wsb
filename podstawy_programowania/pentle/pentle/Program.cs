using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pentle
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Napisz program, który za pomocą indtrukcji do while 
            //dla danych wartości zmieniającyczh się w przedziale od 0 do 15 onlicza wartość funkcji
            //y=4x

            Console.WriteLine("Program wartości funkcji y=4x \n");
            Console.WriteLine("Na Do While");


            int x=1,y=0;
            do
            {
                Console.Write("x=" + x);
                y = 4 * x;
                Console.Write("   y=" + y + "\n");
                x++;
            } while (x <= 15);

            Console.WriteLine("\nNa While ");

            x = 1;
            y = 0;


                //napisz program znajdujący się powyżej za pomocą pentli while 
                while (x <= 15)
            {
                Console.Write("x=" + x);
                y = 4 * x;
                Console.Write("   y=" + y + "\n");
                x++;
            }
            

            //Napisz progkam, który za pomocą instrukcji while dla danycn warotści x zmieniających się w przedziale 
            // od 1 do 50 obliczy ich sumę 
            int x = 1,y=0;


            while (x <= 50)
            {
                y = x + y;
                x++;
            }
            Console.WriteLine("Suma wszystkich liczb z 50 wynosi: " + y);


            Napisz program, który za pomocą pentli for zsumuje liczby nie parzyste z przedziału od 1 do 10
            

            int suma = 0;
            for (int i=1; i <= 10; i++)
            {

                if (i % 2 != 0)
                    suma += i;
            }
            Console.WriteLine("Suma wynosi: "+ suma);

    


            //wyświetl tabliczkę mnożenia za pomocą dwóch pętli do wile

            int x=0,y=0;
            do
            {
                x = y + 1;
                Console.Write(x + " \t");
                y = 1 + x;
                Console.Write(y + " \t");
                x++;
            } while (x < 10);
            Console.WriteLine("\n");

            x = 0;
            y = 0;
            do
            {
                x = y + 2;
                Console.Write(x + " \t");
                y = 2 + x;
                Console.Write(y + " \t");
                x = y;
            } while (x <= 19);
            Console.WriteLine("\n");

            x = 0;
            y = 0;
            do
            {
                x = y + 3;
                Console.Write(x + " \t");
                y = 3 + x;
                Console.Write(y + " \t");
                x = y;
            } while (x <= 29);
            Console.WriteLine("\n");

            x = 0;
            y = 0;
            do
            {
                x = y + 4;
                Console.Write(x + " \t");
                y = 4 + x;
                Console.Write(y + " \t");
                x = y;
            } while (x <= 39);

            Console.WriteLine("\n");

            x = 0;
            y = 0;
            do
            {
                x = y + 5;
                Console.Write(x + " \t");
                y = 5 + x;
                Console.Write(y + " \t");
                x = y;
            } while (x <= 49);

            Console.WriteLine("\n");

            x = 0;
            y = 0;
            do
            {
                x = y + 6;
                Console.Write(x + " \t");
                y = 6 + x;
                Console.Write(y + " \t");
                x = y;
            } while (x <= 59);

            Console.WriteLine("\n");

            x = 0;
            y = 0;
            do
            {
                x = y + 7;
                Console.Write(x + " \t");
                y = 7 + x;
                Console.Write(y + " \t");
                x = y;
            } while (x <= 69);

            Console.WriteLine("\n");

            x = 0;
            y = 0;
            do
            {
                x = y + 8;
                Console.Write(x + " \t");
                y = 8 + x;
                Console.Write(y + " \t");
                x = y;
            } while (x <= 79);

            Console.WriteLine("\n");

            x = 0;
            y = 0;
            do
            {
                x = y + 9;
                Console.Write(x + " \t");
                y = 9 + x;
                Console.Write(y + " \t");
                x = y;
            } while (x <= 89);

            Console.WriteLine("\n");

            x = 0;
            y = 0;
            do
            {
                x = y + 10;
                Console.Write(x + " \t");
                y = 10 + x;
                Console.Write(y + " \t");
                x = y;
            } while (x <= 99);
            


            int n = 10, row, col;

            row = 1;
            do
            {
                col = 1;
                do { 

                Console.Write(row * col + "\t");
                    col++;
            } while (col <= n);
            row++;
            Console.WriteLine();
        }while (row <= n);

    

            Napisz program, który wyświetli duże litery alfabetu od a do if od z do a z wykozystaniem pentli for 
            np A, B, C, .....
            np Z, Y, X, .....




    */

            char a = 'A';
            a--;
            while (a != 'Z')
            {
                a++;
                if (a != 'Z')
                    Console.Write(a + ", ");
                else
                    Console.Write(a + ".");
          }

            Console.WriteLine("\n");

            char c = 'Z';
            c++;
            while (c != 'A')
            {
                c--;
                if (c != 'A')
                    Console.Write(c + ", ");
                else
                    Console.Write(c + ".");
            }

            Console.Write(" \n");

            //continue
            int j = 1;
            for (; j <=10; j++)
            {
                if ( j==2 ||j==5 ||j==7)
            continue;
                else
                    Console.Write(" "+j);


            }
            Console.ReadKey();
        }
    }
}
   
