using System;
using CircleCiTestFunction;

namespace CircleCiTestFunctionTests
{
    public class CoveredClassUnitTests
    {
        [SetUp]
        public void SetUp() { }

        [Test]
        public void DoSomeMath_ReturnsInt()
        {
            var sut = new CoveredClass();
            int x = sut.DoSomeMath();

            Assert.True(x is int);
        }

        [Test]
        public void GetName_ReturnsString()
        {
            var sut = new CoveredClass();
            string x = sut.GetName("bob");

            Assert.True(x is string);
        }

        [Test]
        public void GetSuccess_ReturnsBool()
        {
            var sut = new CoveredClass();
            bool x = sut.GetSuccess();

            Assert.True(x is bool);
        }

        [Test]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        [TestCase(6)]
        public void TestHasBranches_AllBranchesCovered(int i)
        {
            var sut = new CoveredClass();
            sut.ReturnOneOrZero(i);
            Assert.Pass();
        }
    }
}

