using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursieveMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 6;
            int m = 9;
            int sum = CalculateSumRecursive(n, m);
            Console.WriteLine($"The sumof given range is {sum}");
        }
        static int CalculateSumRecursive(int n, int m)
        {
            int sum = n;
            if (n<m)
            {
                n++;
                return sum += CalculateSumRecursive(n, m);

            }
            return sum;

        }
    }
}
