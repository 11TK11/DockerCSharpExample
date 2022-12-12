using NUnit.Framework;

namespace DotNet.Docker
{
    [TestFixture]
    public class Class2
    {
        [Test]
        public void Test4()
        {
            Assert.AreEqual(1, 1);
        }

        [Test]
        public void Test5()
        {
            Assert.AreEqual(1, 2);
        }

        [Test]
        public void Test6()
        {
            Assert.AreEqual(1, 1);
        }
    }
}
