using lab4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testlab4
{
    public class B2
    {
        bai2 sn = new bai2();
        [Test]
        [TestCase(1, 2, 0.5)]
        [TestCase(2, 2, 1)]
        [TestCase(-2, 2, -1)]
        [TestCase(4, -1, 4)]
        [TestCase(1, 0, 0)]
        [TestCase(0, 2, 0)]
        [TestCase(10, 2, 5)]
        [TestCase(10, -1, -10)]
        [TestCase(15, 2, 7)]
        [TestCase(-10, 2, -5)]
        public void Test(double a, double b, double expresult)
        {
            try
            {
                double value = sn.SoNguyen(a, b);
                Assert.AreEqual(value, expresult);
            }
            catch (DivideByZeroException)
            {
                Assert.IsTrue(true, "Expected DivideByZeroException");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Assert.Fail($"{ex.Message}");
            }
        }
    }
}
