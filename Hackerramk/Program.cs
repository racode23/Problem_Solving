using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerramk
{
    internal class Program
    {
        //Questionm-1
        /*Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero.
        Print the decimal value of each fraction on a new line with places after the decimal*/
        static void Main(string[] args)
        {

            double positivesum = 0;
            double Negitveesum = 0;
            double Zerosum = 0;
            double ans = 0;
            string result = "";


           

            ArrayList arr = new ArrayList();
            arr.Add(-4);
            arr.Add(3);
            arr.Add(-9);
            arr.Add(-0);
            arr.Add(-4);
            arr.Add(1);

            for (int i = 0; i < arr.Count; i++)
            {
                
                    if ((int)arr[i] >0)
                    {


                       positivesum++;
                        
                    }

                    if ((int)arr[i] <0)
                    {

                        
                        Negitveesum ++;
                       
                    }
                    if ((int)arr[i] == 0)
                    {

                        Zerosum ++;
                        
                    }

              
            }
            ans = positivesum / arr.Count;
            result=ans.ToString("0.######");
            Console.WriteLine(result);
            ans = Negitveesum / arr.Count;
            result = ans.ToString("0.######");
            Console.WriteLine(result);
            ans = Zerosum / arr.Count;
            result = ans.ToString("0.######");
            Console.WriteLine(result);


            Console.ReadLine();
        }
    }
    
}
