using lab4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testlab4
{
    public class B3
    {
        bai3 bai3 = new bai3();

        [Test]
        [TestCase(new double[] {},3)]
        [TestCase(new double[] {1,2,3 }, 3)]
        [TestCase(new double[] {0 }, 3)]
        [TestCase(new double[] {1,5,2,7,4 }, 3)]
        [TestCase(new double[] {-1,4,7,-2 }, 3)]
        [TestCase(new double[] {0.4,5,8,1 }, 3)]
        public void Test(double[] so, double expresult)
        {
            try
            {
                double value = bai3.TinhTrungBinh(so);
                Assert.AreEqual(value, expresult);
            }
            catch (ArithmeticException ex)
            {
                Assert.AreEqual(ex.Message, "Không thể tính trung bình cộng của danh sách rỗng.");
            }
        }
    }
}
