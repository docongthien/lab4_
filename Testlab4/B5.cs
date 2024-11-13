using lab4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testlab4
{
    public class B5
    {
        bai5 bai5s = new bai5();
        [Test]
        [TestCase("", "")]
        [TestCase("Jane Doe", "Jane Doe")]
        [TestCase("Nguyen Van A", "Nguyen Van A")]
        [TestCase("John", "John")]
        [TestCase("ThisIsALongName", "ThisIsALongName")]
        [TestCase("123", "123")]
        [TestCase("John Doe!", "John Doe!")]
        [TestCase("  John Doe  ", "  John Doe  ")]
        [TestCase("John Doe", "John Doe")]
        [TestCase("  John Doe  ", "  John Doe  ")]
        [TestCase("   ", "")]
        public void testb5(string name, string expected)
        {
            try
            {
                string value = bai5s.GetName(name);
                Assert.AreEqual(expected, value);
            }
            catch (NullReferenceException ex)
            {
                Assert.IsTrue(true, "không được là rỗng");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}
