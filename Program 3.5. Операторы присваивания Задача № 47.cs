using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program48
{
    internal class Program
    {
        static void Main()
        {
            int a = 5, b = 10, c = 0;
            c = a = b; // сначала a = b → a=10, затем c = a → c=10
            Console.WriteLine($"c после c = a = b: {c}"); // 10
            Console.WriteLine($"a: {a}, b: {b}");         // a=10, b=10
        }
    }
}
