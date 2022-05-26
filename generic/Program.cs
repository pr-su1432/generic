// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
namespace generic
{
    class program
    {
        public static void Main(string[] args)
        {
            var log = NLog.LogManager.GetCurrentClassLogger();
            log.Info("generic program started");
            int[] intArry = { 1, 2, 3, 4, 5, 6 };
            double[] doubleArry = { 1.1, 2.2, 3.3, 4.4, 5.5 };
            char[] charArry = { 'P', 'R', 'A', 'S', 'A', 'N', 'N', 'A' };

            program.toprint<int>(intArry);
            program.toprint<double>(doubleArry);
            program.toprint<char>(charArry);

        }

        public static void toprint<T>(T[] inputArry)
        {
            foreach (var element in inputArry)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("----------------------");
        }
        
    }
}

