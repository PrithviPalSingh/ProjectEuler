using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class PalindromeProblem
    {
        public PalindromeProblem()
        {

        }

        public bool IsPalindrome(double N)
        {
            var a = N.ToString().ToCharArray();
            for (int i = 0; i < a.Length / 2; i++)
            {
                if (a[i] != a[a.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }

        public void PrintPalindrome()
        {
            int t = 1;// Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                int n = 101101;// Convert.ToInt32(Console.ReadLine());
                if (n <= 101101 || n >= 1000000)
                    return;

                bool found = false;
                for (double i = n - 1; i >= 0; i--)
                {
                    if (IsPalindrome(i))
                    {
                        for (double j = 100; j <= 999; j++)
                        {
                            if ((i / j).ToString().Length == 3)
                            {
                                Console.WriteLine(i);
                                found = true;
                                break;
                            }
                        }

                        if (found)
                            break;
                    }
                }
            }
        }
    }
}
