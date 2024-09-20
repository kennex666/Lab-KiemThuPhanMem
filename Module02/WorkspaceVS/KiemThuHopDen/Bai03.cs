using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KiemThuHopDen
{
    [TestClass]
    public class Bai03
    {
        MethodLibrary.MethodLibrary mtl = new MethodLibrary.MethodLibrary();

        [TestMethod]
        public void TestMethod1()
        {
            int num = 13;
            bool expectedResult = true;
            bool actualResult = mtl.primeCheck(num);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int num = 10;
            bool expectedResult = false;
            bool actualResult = mtl.primeCheck(num);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Exception actualResult = null;
            try
            {
                int num = -1;
                mtl.primeCheck(num);
            } catch( Exception e ) {
                actualResult = e;
            }
            Assert.IsNotNull(actualResult);
        }


        [TestMethod]
        public void TestMethod4()
        {
            Exception actualResult = null;
            try
            {
                int num = 1001;
                mtl.primeCheck(num);
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
            int num = 1;
            bool expectedResult = false;
            bool actualResult = mtl.primeCheck(num);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod6()
        {
            int num = 1000;
            bool expectedResult = false;
            bool actualResult = mtl.primeCheck(num);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod7()
        {
            Exception actualResult = null;
            try
            {
                int num = -1;
                mtl.primeCheck(num);
            }
            catch (Exception e)
            {
                actualResult = e;
            }
            Assert.IsNotNull(actualResult);
        }


        [TestMethod]
        public void TestMethod8()
        {
            Exception actualResult = null;
            try
            {
                int num = 1001;
                mtl.primeCheck(num);
            }
            catch (Exception e)
            {
                actualResult = e;
            }
            Assert.IsNotNull(actualResult);
        }
    }
}