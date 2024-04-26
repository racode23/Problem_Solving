using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArray
{
    internal class Reverse
    {
        public static void Main() {
            int []array = {1,2,3,4,5,6,7,9};

            foreach (int i in array)
            {

                Console.WriteLine(i);
            }

            Array.Reverse(array);

            Console.WriteLine("Rrverse-:");

            foreach (int  i in array) { 
            
             Console.WriteLine(i);
            }
           Console.ReadLine();
        }

    }
}
