using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            FindSum();

            Console.Read();
        }

        /// <summary>
        /// Project Euler #1: Multiples of 3 and 5
        /// </summary>
        /// <param name="n"></param>
        static void FindSum()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                long n = 100;// Convert.ToInt32(Console.ReadLine());
                long sum = 0;
                long p = (n - 1) / 3;
                sum = ((3 * p * (p + 1)) / 2);

                p = (n - 1) / 5;
                sum = sum + ((5 * p * (p + 1)) / 2);

                p = (n - 1) / 15;
                sum = sum - ((15 * p * (p + 1)) / 2);
                Console.WriteLine(sum);
            }
        }
    }
}
