
using System;

namespace Sandbox.Prod 
{
    public class Solution
    {
        public string DefangIPaddr(string address) 
        {
            string oldString = ".";

            string newString = "[.]";

            return address.Replace(oldString, newString);
        }
    }

}

