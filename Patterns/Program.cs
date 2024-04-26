using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number?");
            var num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num;i++) {
                for (int j = 0; j < num; j++) {
                    Console.Write(" "+"*");
                }
              Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
