using System;
using System.IO;

namespace csharp_console
{
    class Program
    {
        static void Main(string[] args)
        {
            string output = $"Hello {args[0]}!";
            Console.WriteLine(output);
            File.WriteAllTextAsync("output.txt", output);
        }
    }
}
