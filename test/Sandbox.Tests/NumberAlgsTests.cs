using System;
using Xunit;
using Sandbox.Prod;

namespace Sandbox.Tests
{
    public class NumberAlgsTests
    {
        [Fact]
        public void TestSmallerNumbersThanCurrent()
        {
            //arrange
            int[] nums1 = {8,1,2,2,3};
            int[] nums2 = {6,5,4,8};
            int[] nums3 = {7,7,7,7};
            int[] expAns1 = {4,0,1,1,3}; 
            int[] expAns2 = {2,1,0,3};
            int[] expAns3 = {0,0,0,0};
            NumberAlgs numberAlgsObject = new NumberAlgs();
            //act
            var actAns1 = numberAlgsObject.SmallerNumbersThanCurrent(nums1);
            var actAns2 = numberAlgsObject.SmallerNumbersThanCurrent(nums2);
            var actAns3 = numberAlgsObject.SmallerNumbersThanCurrent(nums3);
            

            //assert
            Assert.Equal(expAns1, actAns1);
            Assert.Equal(expAns2, actAns2);
            Assert.Equal(expAns3, actAns3);
        }
    }
}