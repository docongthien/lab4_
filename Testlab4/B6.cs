using lab4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testlab4
{
    public class B6
    {
        bai6 b6 = new bai6(); 
        [Test]
        [TestCase(new int[] {  }, 0)]
        [TestCase(new int[] {1,2,3,4 }, 1)]
        [TestCase(new int[] {1,2,3,4,5,6 }, 1)]
        [TestCase(new int[] {2,5,3,7 }, 2)]
        [TestCase(new int[] { 9,6,2,1 }, 1)]
        [TestCase(new int[] { -1, 2, 2, 1 }, -1)]
        [TestCase(new int[]  { 4, 7, 3, 3,6, 9, 0 }, 0)]
        [TestCase(new int[] { 4, 7, 3, 3, 6, 9, 0 ,4,9}, 0)]
        [TestCase(new int[] { -1,-2,-3,-4 }, -4)]
        [TestCase(new int[] {  -2, -1, 0, 1, 2 }, -2)]
        [TestCase(new int[] { -10,-20,10,20 }, -20)]
        public void Testtongpttms(int[] arr, int expresult)
        {
            try
            {
                double value = b6.GetMin(arr);
                Assert.AreEqual(value, expresult);
            }
            catch (Exception ex)
            {
                Assert.Fail($"error: {ex.Message}");
            }
        }

    }

}
