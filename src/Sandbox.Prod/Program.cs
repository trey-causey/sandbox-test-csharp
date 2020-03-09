using System;
using System.Collections.Generic;

namespace Sandbox.Prod
{
    class Program
    {
        static void Main(string[] args)
        {
                
        }

        public static void printArray(int[] arrayToPrint)
        {
            foreach(int e in arrayToPrint)
            {
                Console.Write($"{e} ");
            }
        }
    }
}
