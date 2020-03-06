
using System;

namespace Sandbox.Prod 
{
    public class StringAlgs
    {
        public string DefangIPaddr(string address) 
        {
            string oldString = ".";

            string newString = "[.]";

            return address.Replace(oldString, newString);
        }
    }

}

