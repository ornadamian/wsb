using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[,] values = new int[,]
            {
             {1,2,3,4},
             {5,6,7,8},
             {9,10,11,12},
             {13,14,15,16},

           };

            for (int i=0;i<4; i++)
            {
                for (int j = 0; j<4;j++)
                {
                  Console.Write(values[i,j] + "\t");
                 }
                Console.WriteLine();
            } 
            */

            /*
            int[,] numbers = new int[3, 3];

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    numbers[i, j] = i * 3 + j;
                }
            }

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.Write(numbers[i, j] + "\t");
                }
                Console.WriteLine();
            }

            */

            /*
            Console.WriteLine("Rozmiar zewnętrznego wymiaru tablicy nieregularnej: {0)\n");


            int[][] number = new int[3][]
            {
                new int[] { 1 ,2 },
                new int[] { 3, 4, 5, 6 },
                new int[] { 7 },
            };

            for (int i = 0; i < number.Length; i++)
            {
                for (int j = 0; j < number[i].Length; j++)
                {
                    Console.WriteLine("number [{0},{1}] = " + number[i][j], i, j);
                }
                Console.WriteLine();
            }

            //Uproszcznew wyrażenia inicjalizacji tablic 

            Char[] vowels = { 'a', 'b', 'i', 'o', 'u' };
            Console.WriteLine(vowels[0]); //a

            byte[,] age =
            {
                {20,30 },
                {15,35 },
                {15,25 }
               };
            Console.WriteLine(age[2, 0]);

            string[][] name =

            {
                new string [] {"Katarzyna"},
                new string [] {"Krzysztof","Anna"},
                new string [] {"Paweł"},
            };

            Console.WriteLine(name[1][1]); //Emilia

            // ilość wyników



            Console.WriteLine("Samogłoski: " + vowels.Rank); //1
            Console.WriteLine("Wiek: " + age.Rank); //2
            Console.WriteLine("Wiek: " + name.Rank); //1
            */

            // Definicja tabeli o 3 wierszach i 4 kolumnach
            int[,] a = new int[3, 4] {
            {0,1,2,3 }, // wiersz o indeksie 0
            {4,5,6,6 }, // wiersz o indeksie 1
            {8,9,10,11 } // wiersz o indeksie 2
        };
            // Wypisanie elementów w konsoli
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("a[{0}, {1}] = {2}", i, j, a[i, j]);
                }
            }
            Console.ReadLine();
            // Wynik działania programu
            //a[0, 0] = 0
            //a[0, 1] = 1
            //a[0, 2] = 2
            //a[0, 3] = 3
            //a[1, 0] = 4
            //a[1, 1] = 5
            //a[1, 2] = 6
            //a[1, 3] = 6
            //a[2, 0] = 8
            //a[2, 1] = 9
            //a[2, 2] = 10
            //a[2, 3] = 11




            Console.ReadKey();
        }

    }
}
