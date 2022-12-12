using NUnit.Framework;

namespace DotNet.Docker
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(1, 1);
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(1, 2);
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(1, 1);
        }
    }
}
