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
    }
}
