using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictinary
{
    internal class Dictionary
    {
        public static void Main() {
            Dictionary<int, string> country = new Dictionary<int, string>();

            country.Add(1,"Sri lanka");
            country.Add(2, "India");
            country.Add(3, "Canada");

        }
    }
}
