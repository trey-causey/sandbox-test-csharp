using System;

namespace Sandbox.Prod
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {8,1,2,2,3};

            Solution solutionObject = new Solution();

            var ans = solutionObject.SmallerNumbersThanCurrent(nums);
            PrintValues(ans);

            void PrintValues(int[] myArr)
            {
            foreach (int i in myArr)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            } 
            //call find smallest number function with array input
            //findSmallerValuesByElement

            //  System.Console.WriteLine($"The answer is: {ApproxMath.approxSQRT(25)}");
        //  var a = ApproxMath.approxSQRT(14);
        //  System.Console.WriteLine($"the answer is: {a:N8}");
        }
    }
}
