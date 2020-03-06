using System;
using Xunit;
using Sandbox.Prod;

namespace Sandbox.Tests
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            //arrange
           int[] expectedArray1 = {2,4,4,4};
           int[] actualArray1 = {};
           int[] nums1 = {1,2,3,4};
           Solution arrayObject1 = new Solution();
           
            //act
            
            actualArray1 = arrayObject1.DecompressRLElist(nums1);
            //assert
            Assert.Equal(expectedArray1, actualArray1);
            
        }
    }
