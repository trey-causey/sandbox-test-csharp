
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

        public int BalancedStringSplit(string s) {
            string str = s.ToUpper();
            int counter = 0;
            int bal = 0;
            foreach(char e in str)
            {
                if(e == 'R')
                {
                    bal++;
                } else if(e == 'L')
                {
                    bal--;
                }
                if(bal == 0){ counter++;}

            }
        return counter;
        }

        public string RotationalCypher(string s, int o)
       {    
           string ABC = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

           int offset;
           if(o == 26)
           {
            offset = 0;
           } else {offset = o;}
           
           int x = ABC.IndexOf(s);
           char[] str = ABC.ToCharArray();
           return str[x + offset].ToString();
           
       }
    }

    

}

