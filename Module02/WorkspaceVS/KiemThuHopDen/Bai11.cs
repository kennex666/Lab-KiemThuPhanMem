using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KiemThuHopDen
{
    [TestClass]
    public class Bai11
    {
        MethodLibrary.MethodLibrary ml = new MethodLibrary.MethodLibrary();
        [TestMethod]
        public void TestMethod1()
        {
            string s1 = "",
                   s2 = "",
                   s3 = "",
                   expectedResult = "";

            string actualResult = ml.ThayThe(s1, s2, s3);

            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void TestMethod2()
        {
            string s1 = "DuongThaiBao",
                   s2 = "",
                   s3 = "Hehe",
                   expectedResult = "DuongThaiBao";

            string actualResult = ml.ThayThe(s1, s2, s3);

            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void TestMethod3()
        {
            string s1 = "DuongThaiBao",
                   s2 = "Duong",
                   s3 = "",
                   expectedResult = "ThaiBao";

            string actualResult = ml.ThayThe(s1, s2, s3);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod4()
        {
            string s1 = "DuongThaiBao",
                   s2 = "Hehe",
                   s3 = "Hi",
                   expectedResult = "DuongThaiBao";

            string actualResult = ml.ThayThe(s1, s2, s3);

            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void TestMethod5()
        {
            string s1 = "DuongThaiBao",
                   s2 = "DuongThai",
                   s3 = "LuuVan",
                   expectedResult = "LuuVanBao";

            string actualResult = ml.ThayThe(s1, s2, s3);

            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
