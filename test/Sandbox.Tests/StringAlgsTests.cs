using System;
using Xunit;
using Sandbox.Prod;

namespace Sandbox.Tests
{
    public class StringAlgsTests
    {
        [Fact]
        public void TestDefangIPaddr()
        {
            //arrange
            string inputAddress = "1.1.1.1";
            string expectedOutputAddress = "1[.]1[.]1[.]1";
            string actualOutputAddress;
            StringAlgs stringAlgsObject = new StringAlgs();
           
            //act
            actualOutputAddress = stringAlgsObject.DefangIPaddr(inputAddress);

            //assert
            Assert.Equal(expectedOutputAddress, actualOutputAddress);
            
        }
        [Fact]
        public void TestNumHewelsInStones()
        {
            //arrange
            string J ="z";
            string S = "ZZ";
            int expAns1 = 0;
            int actAns1;
            StringAlgs solutionObj = new StringAlgs();
            //act

            actAns1 = solutionObj.NumJewelsInStones(J, S);
            //assert
            Assert.Equal(expAns1, actAns1);
        }

         [Fact]
        public void TestBalancedStringSplit()
        {
            //arrange
            string s = "RLRRLLRLRL";
            var solObj = new StringAlgs();
            int expAns = 0;
            int actAns = 4;
            //act
            expAns = solObj.BalancedStringSplit(s);
            //assert
            Assert.Equal(expAns, actAns);

        }

        [Fact]
        public void TestRotationalCypher()
        {
        //arange
        var solObj = new StringAlgs();
        string t = "A";
        int offset = 26;
        string expStr = "A";
        string actStr = "";
        //act 
        actStr = solObj.RotationalCypher(t,offset);
        //assert
        Assert.Equal(expStr,actStr);
        }

        
    }
}
