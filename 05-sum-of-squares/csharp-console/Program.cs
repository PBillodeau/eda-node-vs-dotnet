using System;
using System.Linq;
using System.Collections.Generic;

namespace csharp_console
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> n = Array.ConvertAll(args, s => int.Parse(s)).ToList();

            Console.WriteLine(findSum(n));
            Console.WriteLine(findSum2(n));
        }

        static int findSum(List<int> n)
        {
            int sum = 0;

            for (int i = 0; i < n.Count; i++) {
                sum += n[i]*n[i];
            }

            return sum;
        }

        static int findSum2(List<int> n)
        {
            return n.Select(o => o*o).Sum();
        }
    }
}
