using System;
using System.Linq;
using System.Collections.Generic;

namespace csharp_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(findSum(Int32.Parse(args[0])));
            Console.WriteLine(findSum2(Int32.Parse(args[0])));
            Console.WriteLine(findSum3(Int32.Parse(args[0])));
        }

        static int findSum(int n)
        {
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 || i % 5 == 0) {
                    sum += i;
                }
            }

            return sum;
        }

        static int findSum2(int n)
        {
            List<int> match = new List<int>();

            for (int i = 1; i <= n; i++) {
                if (i % 3 == 0 || i % 5 == 0) {
                    match.Add(i);
                }
            }

            return match.Sum();
        }

        static int findSum3(int n)
        {
            return Enumerable.Range(1, n).Where(o => o % 3 == 0 || o % 5 == 0).Aggregate((a, b) => a + b);
        }
    }
}
