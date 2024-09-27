using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KiemThuHopDen
{
    [TestClass]
    public class Bai13
    {
        MethodLibrary.MethodLibrary ml = new MethodLibrary.MethodLibrary();
        [TestMethod]
        public void TestMethod1()
        {
            int[] a = { 1, 2, 3, 2, 1 };
            int n = 5;
            bool expRs = true;
            bool actRs = ml.IsSymmetry(a, n);

            Assert.AreEqual(expRs, actRs);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] a = { 1, 1, 2, 2, 2 };
            int n = 5;
            bool expRs = false;
            bool actRs = ml.IsSymmetry(a, n);

            Assert.AreEqual(expRs, actRs);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int[] a = { 1, 2, 3, 2, 1 };
            int n = 4;
            bool expRs = false;
            bool actRs = ml.IsSymmetry(a, n);

            Assert.AreEqual(expRs, actRs);
        }

        [TestMethod]
        public void TestMethod4()
        {
            int[] a = { 1, 2, 3, 2, 1 };
            int n = 6;
            bool expRs = false;
            bool actRs = ml.IsSymmetry(a, n);

            Assert.AreEqual(expRs, actRs);
        }
    }
}
