﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wskazniki4
{
    class Program
    {
        struct Test
        {
            public int n;
        }
        unsafe static void Main(string[] args)
        {
            Test x = new Test();
            Test* p = &x;
            p->n = 20;

            (*p).n = 20;


            Console.WriteLine(x.n);
            Console.ReadKey();
        }
    }
}
