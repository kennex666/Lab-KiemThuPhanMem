using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KiemThuHopDen
{
    [TestClass]
    public class Bai05
    {
        MethodLibrary.MethodLibrary mtl = new MethodLibrary.MethodLibrary();
        [TestMethod]
        public void TestMethod1()
        {
            string sBin = "1001";
            long expectedResult = 9;
            long actualResult = mtl.BinToDec(sBin);
            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void TestMethod2()
        {
            FormatException actualResult = null;
            try
            {
                string sBin = "ABC";
                mtl.BinToDec(sBin);
            } catch (FormatException e)
            {
                actualResult = e;
            }
            Assert.IsNotNull(actualResult);
        }

    }
}
