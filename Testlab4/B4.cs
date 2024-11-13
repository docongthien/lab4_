using lab4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testlab4
{
    public class B4
    {
        bai4 bai4 = new bai4();
        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 2, 3)]
        [TestCase(new int[] { 10, 20, 30 }, 1, 20)]
        [TestCase(new int[] { -1, 0, 1 }, 0, -1)]
        [TestCase(new int[] { 5, 10, 15, 20 }, 3, 20)]
        [TestCase(new int[] { 2, 4, 6, 8 }, 0, 2)]
        [TestCase(new int[] { 1, 3, 5, 7, 9 }, 4, 9)]
        [TestCase(new int[] { }, -1, 0)]
        [TestCase(new int[] { 1 }, 0, 1)]
        [TestCase(new int[] { 1, 2, 3 }, 3, 3)]
        [TestCase(new int[] { 1, 2, 3 }, 5, 0)]
        public void testb4(int[] array, int index, int expected)
        {
            try
            {
                int actual = bai4.mang(array, index);
                Assert.AreEqual(expected, actual);
            }
            catch (IndexOutOfRangeException)
            {
                Assert.IsTrue(true, "lỗi");
            }
        }
    }
}
