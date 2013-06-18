using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello this is a test");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine((i+1).ToString());
            }

            Console.ReadKey();
        }
    }
}
