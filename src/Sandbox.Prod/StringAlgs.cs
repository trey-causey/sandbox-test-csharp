
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

        public int NumJewelsInStones(string J, string S) {
        int x = 0;
        foreach(char a in J)
        {
            foreach(char b in S)
            {
                if(a.Equals(b))
                {
                    x++;
                }
            }
        }

        return x;
        }
    }

}

