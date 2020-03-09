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
            // Assert.Equal(expAns1, actAns1);
            // Assert.Equal(expAns2, actAns2);
            // Assert.Equal(expAns3, actAns3);
        }

        [Fact]
        public void TestDecompressRLElist()
        {
            //arrange
           int[] expectedArray1 = {2,4,4,4};
           int[] expectedArray2 = {1,3,3};
           int[] actualArray1 = {};
           int[] actualArray2 = {};
           int[] nums1 = {1,2,3,4};
           int[] nums2 = {1,1,2,3};
           NumberAlgs arrayTestObject1 = new NumberAlgs();
           
            //act
            
            actualArray1 = arrayTestObject1.DecompressRLElist(nums1);
            actualArray2 = arrayTestObject1.DecompressRLElist(nums2);
            //assert
            Assert.Equal(expectedArray1, actualArray1);
            Assert.Equal(expectedArray2, actualArray2);
            
        }
        [Fact]
        public void TestSubtractProductAndSum()
        {
            //arrange 
            NumberAlgs solObj = new NumberAlgs();
            int n1 = 234;
            int n2 = 4421;
            int expAns1 = 15;
            int expAns2 = 21;
            
            //act
            int actAns1 = solObj.SubtractProductAndSum(n1);
            int actAns2 = solObj.SubtractProductAndSum(n2);

            //assert
            Assert.Equal(expAns1, actAns1);
            Assert.Equal(expAns2, actAns2);

        }

        [Fact]
        public void TestFindNumbers()
        {
            //arange
                int[] nums = {12,345,2,6,7896};
                NumberAlgs numObj = new NumberAlgs();
                int expAns1 = 2;
                int actAns1;
            //act
                actAns1 = numObj.FindNumbers(nums);
            //assert
            Assert.Equal(expAns1, actAns1);
        }
    }
}