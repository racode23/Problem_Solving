using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <1; i++) {

                for (int j = 0; j <= 5; j++)
                {

                    Console.Write("*");

                    if (j == 5) { 
                        for (int z = 0; z <= 5; z++)
                        {
                            for (int k = 0; k <= 5; k++)
                            {

                                Console.Write(" ");


                            }
                            Console.WriteLine("*");
                        }
                  }
                }
                for (int k = 0; k <= 5; k++)
                {

                    Console.WriteLine("*");

                  
                }
               

            }

            Console.ReadLine();
        }
        
    }
}
