using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace pliki_2
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo wsbDir = new DirectoryInfo(".");
            //Console.WriteLine(wsbDir.FullName);

            //DirectoryInfo studentDir = new DirectoryInfo("C:\\Users\\Student\\Desktop");
            //DirectoryInfo studentDir = new DirectoryInfo(@"C:\Users\Student\Desktop");
            DirectoryInfo studentDir = new DirectoryInfo(@"C:\Users\Student");

            Console.WriteLine(studentDir.FullName);
            Console.WriteLine(studentDir.Name);
            Console.WriteLine(studentDir.Parent);
            Console.WriteLine(studentDir.Attributes);
            Console.WriteLine(studentDir.CreationTime);

            DirectoryInfo dataDir = new DirectoryInfo(@"C:\Users\Student\C#Files");

            string[] customers =
            {
                "Anna Nowak",
                "Murzynek bamboo",
                "Asia Hore",
            };

            Directory.CreateDirectory("\\Users\\Student\\C#Files");

            string path = @"C:\Users\Student\C#Files";
            try
            {
                if (Directory.Exists(path))
                {
                    Console.WriteLine("Katalog Instenije");
                }
                else
                {
                    Directory.CreateDirectory("\\Users\\Student\\C#Files");
                    string textFilePath = @"C:\Users\Student\C#Files\text.txt";
                    File.WriteAllLines(textFilePath, customers);

                    Console.WriteLine("\n Uttworzono katalog {0}", Directory.GetCreationTime(path));

                    File.WriteAllLines(textFilePath, customers);
                }
            }

            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.ToString());
            }
            DirectoryInfo myDataDir = new DirectoryInfo(path);

            Console.WriteLine();

            FileInfo[] txtFiles = myDataDir.GetFiles("*.txt", SearchOption.AllDirectories);

            Console.WriteLine("ilość plików tekstowych: {0} \n", txtFiles.Length);

            Console.WriteLine("Pliki Tekstowe: ");

            foreach (FileInfo file in txtFiles)
            {
                Console.WriteLine("Nazwa: {0}", file.Name);
                Console.WriteLine("Rozmiar {0}", file.Length);
            }

            if (Directory.Exists(path))
            {
                Console.WriteLine("\n Czy chcesz usunąć katalog ?  1=true 0=false");
                string delete = Console.ReadLine();

                if (delete == "1")
                {
                    Directory.Delete(path, true);
                }

                if (Directory.Exists(path))
                {
                    Console.WriteLine("Katalog został usunięty!");

                }
                else
                {
                    Console.WriteLine("Nie usunąłeś katalogu");
                }

            }


            Console.ReadKey();

        }
    }
}
