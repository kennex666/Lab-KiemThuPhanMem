using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KiemThuHopDen
{
    [TestClass]
    public class Bai14
    {
        MethodLibrary.MethodLibrary ml = new MethodLibrary.MethodLibrary();
        [TestMethod]
        public void TestMethod1()
        {
            int[] a = { 4, 3, 2, 5, 1 };
            int left = 0;
            int right = 4;
            int[] expRs = { 1,2,3,4,5 };
            ml.QuickSort(a, left, right);

            CollectionAssert.AreEqual(a, expRs);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] a = { 4, 3, 2, 5, 1 };
            int left = 4;
            int right = 0;
            int[] expRs = {};
            ml.QuickSort(a, left, right);

            CollectionAssert.AreEqual(a, expRs);
        }



        [TestMethod]
        public void TestMethod3()
        {
            int[] a = { 4, 3, 2, 5, 1 };
            int left = -1;
            int right = 4;
            int[] expRs = { };
            ml.QuickSort(a, left, right);

            CollectionAssert.AreEqual(a, expRs);
        }

        [TestMethod]
        public void TestMethod4()
        {
            int[] a = { 4, 3, 2, 5, 1 };
            int left = 0;
            int right = -1;
            int[] expRs = { };
            ml.QuickSort(a, left, right);

            CollectionAssert.AreEqual(a, expRs);
        }

        [TestMethod]
        public void TestMethod5()
        {
            int[] a = { 4, 3, 2, 5, 1 };
            int left = 0;
            int right = 4;
            int[] expRs = { 1, 2, 3, 4, 5 };
            ml.QuickSort(a, left, right);

            CollectionAssert.AreEqual(a, expRs);
        }


        [TestMethod]
        public void TestMethod6()
        {
            int[] a = { 4 };
            int left = 0;
            int right = 0;
            int[] expRs = { 4 };
            ml.QuickSort(a, left, right);

            CollectionAssert.AreEqual(a, expRs);
        }

        [TestMethod]
        public void TestMethod7()
        {
            int[] a = { 4, 3, 2, 5, 1 };
            int left = -1;
            int right = 4;
            int[] expRs = { };
            ml.QuickSort(a, left, right);

            CollectionAssert.AreEqual(a, expRs);
        }

        [TestMethod]
        public void TestMethod8()
        {
            int[] a = { 4, 3, 2, 5, 1 };
            int left = 0;
            int right = -1;
            int[] expRs = { };
            ml.QuickSort(a, left, right);

            CollectionAssert.AreEqual(a, expRs);
        }

    }
}
