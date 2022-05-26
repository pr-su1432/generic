using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic
{
    internal class generics
    {
        public static void toprint(int[] inputArry)
        {
            foreach(int element in inputArry)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("----------------------");
        }
        public static void toprint(double[] inputArry)
        {
            foreach (double element in inputArry)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("----------------------");
        }
        public static void toprint(char[] inputArry)
        {
            foreach (char element in inputArry)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("----------------------");
        }
    }
}
