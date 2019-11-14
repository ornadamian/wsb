using System;
using First_name;
using Second_Name;

namespace XD
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Console.WriteLine("WSB");

            First_name.name_1 ob1 = new First_name.name1();
            ob1.show();

            name_1 ob2 = new name_1();
            ob2.Show();

            Program ob = new Prog();
            Console.WriteLine(ob.Add(3,5));

            Console.ReadKey();

        }
    }
}

namespace First_name
{
    public void Show()
    {
        Console.WriteLine("Pierwsza przestrzeń nazw");
    }

}

namespace Second_name
{
    public void Show()
    {
        Console.WriteLine("Druga przestrzeń nazw");
    }

}

namespace outer
{
    namespace Middle
    {
        namespace Inner
        {
            class Prog
            {
                public int x, y;

                public int add(int x, int y)
                {
                    return x + y;
                }

            }
        }
    }
}
