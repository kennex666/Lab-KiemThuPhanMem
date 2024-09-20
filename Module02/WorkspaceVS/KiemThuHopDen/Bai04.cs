using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KiemThuHopDen
{
    [TestClass]
    public class Bai04
    {
        MethodLibrary.MethodLibrary mtl = new MethodLibrary.MethodLibrary();
        [TestMethod]
        public void TestMethod1()
        {
            int num = 2000;
            bool expectedResult = true;
            bool actualResult = mtl.IsLeapYear(num);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int num = 2004;
            bool expectedResult = true;
            bool actualResult = mtl.IsLeapYear(num);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int num = 2023;
            bool expectedResult = false;
            bool actualResult = mtl.IsLeapYear(num);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod4()
        {

            Exception actualResult = null;
            try
            {
                int num = 1581;
                mtl.IsLeapYear(num);
            }
            catch (Exception e)
            {
                actualResult = e;
            }
            Assert.IsNotNull(actualResult);
        }


        [TestMethod]
        public void TestMethod5()
        {
            int num = 1582;
            bool expectedResult = false;
            bool actualResult = mtl.IsLeapYear(num);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod6()
        {

            Exception actualResult = null;
            try
            {
                int num = 1581;
                mtl.IsLeapYear(num);
            }
            catch (Exception e)
            {
                actualResult = e;
            }
            Assert.IsNotNull(actualResult);
        }
    }
}
