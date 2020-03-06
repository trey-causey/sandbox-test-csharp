
using System;
using System.Collections;

namespace Sandbox.Prod 
{
    public class Solution
    {
        public int[] DecompressRLElist(int[] nums) 
        {
            int i = (nums.Length % 2);
            Stack thisStack = new Stack();
            if (i == 0 && (nums.Length >=2 && nums.Length <=100))
            {
                
                while(i < (nums.Length))
                {
                    for(int x = 0; x < nums[i]; i*=2 )
                    {
                        thisStack.Push(i + 1);
                    }

                    //the work

                }
                
            }        
           
            return thisStack.CopyTo(nums, 0);
        
        }
    }

}

