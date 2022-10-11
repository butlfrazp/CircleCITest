using System;
using CircleCiTestFunction;

namespace CircleCiTestFunctionTests
{
    [TestFixture]
    public class AnotherCoveredClassUnitTest
    {

        public AnotherCoveredClassUnitTest()
        {
        }

        [Test]
        [TestCase(2f, 1f, 1f)]
        [TestCase(4f, 1f, 3f)]
        [TestCase(5f, 4f, 1f)]
        [TestCase(0f, 0f, 0f)]
        public void AddNumbers_AddsThem(float expected, float x, float y)
        {
            var sut = new AnotherCoveredClass();

            Assert.AreEqual(expected, sut.AddNumbers(x, y));
        }

        [Test]
        [TestCase(0f, 1f, 0f)]
        [TestCase(0f, 0f, 1f)]
        [TestCase(2f, 4f, 2f)]
        [TestCase(3f, 6f, 2f)]
        public void DivideNumbers_DividesThem(float expected, float x, float y)
        {
            var sut = new AnotherCoveredClass();

            Assert.AreEqual(expected, sut.DivideNumbers(x, y));
        }

        [Test]
        [TestCase("Less than 10", 9)]
        [TestCase("Less than 50", 49)]
        [TestCase("Less than 100", 99)]
        [TestCase("Greater than 100", 101)]
        public void GetString_GetsString(string expected, int input)
        {
            var sut = new AnotherCoveredClass();

            Assert.AreEqual(expected, sut.GetString(input));
        }
    }
}

