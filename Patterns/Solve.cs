using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class Solve
    {
        int[,] x;
        Solve()
        {

            x = new int[,] { { 1, 2, 3, 4 }, { 6, 7, 8, 9 } };
        }

        void printarrray()
        {

            for (int i = 0; i < 2; i++)
            {

                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine(x[i, j]);
                }

                Console.WriteLine("\n");
            }
        }
    }
}
