using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving
{
    internal class OddOrEven
    {
        public static void Main()
        {
                int number;
                Console.WriteLine("Enter A number");
                number = int.Parse(Console.ReadLine());
                int result = number % 2;
                if (result == 0)
                {
                    Console.WriteLine("This is a even number ");
                }
                else if (result != 0)
                {
                    Console.WriteLine("This is  Odd number");
                }
            }
        }
    }

