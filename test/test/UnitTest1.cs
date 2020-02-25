using NUnit.Framework;

namespace test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            System.Threading.Thread.Sleep(2000);
        }

        [Test]
        public void Test2()
        {
            System.Threading.Thread.Sleep(40000);
        }
    }
}