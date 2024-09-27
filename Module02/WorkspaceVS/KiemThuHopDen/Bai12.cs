using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KiemThuHopDen
{
    [TestClass]
    public class Bai12
    {
        MethodLibrary.MethodLibrary ml = new MethodLibrary.MethodLibrary();
        [TestMethod]
        public void TestMethod1()
        {
            int[] a = {1, 2, 3, 4, 5, 6, 7, 8};

            int expectedResult = 8;

            int actualResult = ml.Largest(a);
            Assert.AreEqual(expectedResult, actualResult);

        }
        [TestMethod]
        public void TestMethod2()
        {
            int[] a = { };

            int expectedResult = int.MaxValue;

            int actualResult = ml.Largest(a);
            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}
