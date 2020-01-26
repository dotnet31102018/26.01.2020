using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecurrsionFib
{
    class Program
    {
        private static int counter = 0;
        private static int fibb(int x)
        {
            if (x==1)
                return 1;
            if (x==2)
                return 1;

            counter++;

            return fibb(x - 1) + fibb(x - 2);
        }
        private static int fibb_no_rec(int x)
        {
            if (x == 1 || x == 2)
                return 1;
            int a = 1;
            int b = 1;
            int index = 3;
            while (index < x)
            {
                int temp = a + b;
                a = b;
                b = temp;
                index++;
            }
            return a + b;

        }
        static void Main(string[] args)
        {
            Console.WriteLine(fibb(30)); // only O(n) = O(30)

            Console.WriteLine(fibb_no_rec(30)); // pay attention to complexity level ~83K
            Console.WriteLine($"counter = " + counter); // very bad!
        }
    }
}
