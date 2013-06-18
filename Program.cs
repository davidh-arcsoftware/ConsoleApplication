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
            if (BorderFunctions.IsWorking())
            {
                Console.WriteLine("hello this is a test");

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine((i + 1).ToString());
                }

                for (int i = 10; i > 0; i--)
                {
                    Console.WriteLine(i.ToString());
                }

                Console.ReadKey();
            }
        }
    }
}
