using System;

namespace Sandbox.Prod 
{
    public class NumberAlgs
    {
            public int[] SmallerNumbersThanCurrent(int[] nums)
            {
                int[] workerArray = new int[nums.Length];
                int[] outputArray = new int[nums.Length];
                nums.CopyTo(workerArray, 0);
                Array.Sort(workerArray);
                Array.Reverse(workerArray);
                int i = 0;
                foreach(int e in nums)
                {
                    int x = Array.LastIndexOf(workerArray, e);
                    int z = nums.GetUpperBound(0) - x;
                    outputArray[i] = z;
                    i++;               
                }
                return outputArray;
            }
    }

}