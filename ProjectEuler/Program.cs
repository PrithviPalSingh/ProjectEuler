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
            //FindSum();
            //EvenSum();
            //LargestPrimeFactor();
            PalindromeProblem p = new PalindromeProblem();
            p.PrintPalindrome();
            Console.Read();
        }

        /// <summary>
        /// Project Euler #1: Multiples of 3 and 5
        /// </summary>
        /// <param name="n"></param>
        static void FindSum()
        {
            int t = 1;// Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                long n = 10000000000000;// Convert.ToInt32(Console.ReadLine());
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

        static void EvenSum()
        {
            long sum = 0;

            long a = 1;
            for (long b = 2; b <= 100;)
            {
                if (b % 2 == 0)
                {
                    sum += b;
                }

                long c = a + b;
                a = b;
                b = c;
            }

            Console.WriteLine(sum);
        }

        static void LargestPrimeFactor()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                double n = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine(FindLargestPrime(n));
            }
        }

        private static double FindLargestPrime(double n)
        {
            double max = -1;
            while (n % 2 == 0)
            {
                max = 2;
                n = n / 2;
            }

            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                while (n % i == 0)
                {
                    max = i;
                    n = n / i;
                }
            }

            if (n > 2)
                max = n;

            return max;
        }

        public static bool IsPrime(double number)
        {
            if (number == 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}
