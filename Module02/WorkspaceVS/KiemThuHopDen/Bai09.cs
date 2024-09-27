using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KiemThuHopDen
{
    [TestClass]
    public class Bai09
    {
        MethodLibrary.MethodLibrary ml = new MethodLibrary.MethodLibrary();
        [TestMethod]
        public void TestMethod1()
        {
            int s0 = -2;

            long actualResult = 0;
            long expectedResult = 1;
            ml.Sum(s0, out actualResult);
            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void TestMethod2()
        {
            int s0 = 25;

            long actualResult = 0;
            long expectedResult = 28;
            ml.Sum(s0, out actualResult);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
