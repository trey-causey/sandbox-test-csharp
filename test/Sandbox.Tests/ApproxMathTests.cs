using System;
using Xunit;
using Sandbox.Prod;

namespace Sandbox.Tests
{
    public class ApproxMathTests
    {
        [Fact]
        public void TestApproxSQRTFunction()
        {
            //arrange
            double x = 25;
            double expected = Math.Sqrt(x);
            double actual = ApproxMath.approxSQRT(x);
            //act
    
            //assert
            Assert.Equal(expected, actual, 9);

        
        }
    }
}
