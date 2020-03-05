using System;
using Xunit;
using Sandbox.Prod;

namespace Sandbox.Tests
{
    public class SolutionTests
    {
        [Fact]
        public void TestDefangIPaddr()
        {
            //arrange
            string inputAddress = "1.1.1.1";
            string expectedOutputAddress = "1[.]1[.]1[.]1";
            string actualOutputAddress;
            Solution solutionObject = new Solution();
           
            //act
            actualOutputAddress = solutionObject.DefangIPaddr(inputAddress);

            //assert
            Assert.Equal(expectedOutputAddress, actualOutputAddress);
            
        }
    }
}
