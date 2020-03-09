using System;
using System.Collections.Generic;

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

        public int[] DecompressRLElist(int[] nums) 
        {
            
            int i = (nums.Length % 2);
            List<int> listObject = new List<int>();
            if (i == 0 && (nums.Length >=2 && nums.Length <=100))
            {
                while(i < (nums.Length))
                {
                    for(int x = 0; x < nums[i]; x++)
                    {
                    listObject.Add(nums[i+1]);
                    }   
                    i+=2;

                }
            }        
            return listObject.ToArray();
        
        }

        public int SubtractProductAndSum(int n) {
        int p =1;
        int s =0;
        
            while(n>0)
            {
                int x = n%10;
                p*=x;
                s+=x;
                n/=10;
            }
                return p-s;
        }

        public int FindNumbers(int[] nums) {
            int counter = 0;
            foreach(int e in nums)
            {
                int x = e;
                List<int> l = new List<int>();
                while(x>0)
                {
                l.Add(x%10);
                x/=10;
                }
                if(l.Count%2==0)
                {
                    counter++;
                }
            }
            
            return counter;
        }

        public void printArray(int[] arrayToPrint)
        {
            foreach(int e in arrayToPrint)
            {
                Console.Write($"[{e} ");
            }
        }
    }

}