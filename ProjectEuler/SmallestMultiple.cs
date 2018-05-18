using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class SmallestMultiple
    {
        public SmallestMultiple()
        {

        }

        public int FindSmallestMultiple(int N)
        {
            Dictionary<int, int> NumberCount = new Dictionary<int, int>();

            for (int i = 2; i <= N; i++)
            {
                var list = FindFactor(i);

                foreach (var item in list)
                {
                    if (NumberCount.ContainsKey(item.Key))
                    {
                        if (item.Value > NumberCount[item.Key])
                        {
                            NumberCount[item.Key] = item.Value;
                        }
                    }
                    else
                    {
                        NumberCount.Add(item.Key, item.Value);
                    }
                }
            }

            int mul = 1;

            foreach (var item in NumberCount)
            {
                if (item.Value != 0)
                {
                    mul *= (int)Math.Pow(item.Key, item.Value);
                }
            }

            return mul;
        }

        private Dictionary<int, int> FindFactor(int i)
        {
            Dictionary<int, int> InnerNumCounts = new Dictionary<int, int>();
            while (i % 2 == 0)
            {
                i /= 2;
                if (InnerNumCounts.ContainsKey(2))
                {
                    InnerNumCounts[2]++;
                }
                else
                {
                    InnerNumCounts.Add(2, 1);
                }
            }

            for (int j = 3; j <= i; j = j + 2)
            {
                while (i % j == 0)
                {
                    i /= j;
                    if (InnerNumCounts.ContainsKey(j))
                    {
                        InnerNumCounts[j]++;
                    }
                    else
                    {
                        InnerNumCounts.Add(j, 1);
                    }
                }
            }

            return InnerNumCounts;
        }
    }
}
