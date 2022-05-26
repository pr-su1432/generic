using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Generic;


namespace generic
{
    internal class generics
    {
        public static void toprint<T>(T[] inputArry)
        {
            foreach(var element in inputArry)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("----------------------");
        }
       
    }
}
