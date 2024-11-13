using lab4;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;

namespace Testlab4
{
    public class Tests
    {

        Bai1 bai = new Bai1();
        [Test]
        [TestCase(2, 3, 6)]
        [TestCase(5, 10, 50)]
        [TestCase(-1, 5, -5)]
        [TestCase(11, 2, 22)]
        [TestCase(0, 0, 0)]
        [TestCase(10, 10, 100)]
        [TestCase(5.5, 2.5, 13.75)]
        [TestCase(7, 3.14, 21.98)]
        [TestCase(0, 10.5, 0)]
        [TestCase(10.5, 0, 0)]
        public void B1(double a,double b, double expvalue)
        {
            try
            {
                double value = bai.bai1(a, b);
                Assert.AreEqual(value, expvalue);
            }
            catch (ArgumentException ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}