using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KiemThuHopDen
{
    [TestClass]
    public class Bai10
    {
        MethodLibrary.MethodLibrary ml = new MethodLibrary.MethodLibrary();
        [TestMethod]
        public void TestMethod1()
        {
            int n = 5,
                p = 12;
            string s = "DuongThaiBao";
            string expectedResult = "DuongThaiBao";
            string actualResult = ml.HuyChuoi(s, n, p);

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int n = 12,
                p = 5;
            string s = "DuongThaiBao";
            string expectedResult = "DuongThaiBao";
            string actualResult = ml.HuyChuoi(s, n, p);

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int n = 5,
                p = 0;
            string s = "DuongThaiBao";
            string expectedResult = "ThaiBao";
            string actualResult = ml.HuyChuoi(s, n, p);

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void TestMethod4()
        {
            int n = 5,
                p = -1;
            string s = "DuongThaiBao";
            string expectedResult = "DuongThaiBao";
            string actualResult = ml.HuyChuoi(s, n, p);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod5()
        {
            int n = -1,
                p = 0;
            string s = "DuongThaiBao";
            string expectedResult = "DuongThaiBao";
            string actualResult = ml.HuyChuoi(s, n, p);

            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void TestMethod6()
        {
            int n = 0,
                p = 0;
            string s = "DuongThaiBao";
            string expectedResult = "DuongThaiBao";
            string actualResult = ml.HuyChuoi(s, n, p);

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void TestMethod7()
        {
            int n = 5,
                p = -1;
            string s = "DuongThaiBao";
            string expectedResult = "DuongThaiBao";
            string actualResult = ml.HuyChuoi(s, n, p);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod8()
        {
            int n = -1,
                p = 0;
            string s = "DuongThaiBao";
            string expectedResult = "DuongThaiBao";
            string actualResult = ml.HuyChuoi(s, n, p);

            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
