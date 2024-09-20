using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KiemThuHopDen
{

    [TestClass]
    public class Bai06
    {
        MethodLibrary.MethodLibrary mtl = new MethodLibrary.MethodLibrary();

        [TestMethod]
        public void TestMethod1()
        {
            int a = 10, b = 12, c = 6;
            string expr = "Scalene";
            string actr = mtl.Triangle(a, b, c);
            Assert.AreEqual(expr, actr);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int a = 15, b = 15, c = 69;
            string expr = "Isosceles";
            string actr = mtl.Triangle(a, b, c);
            Assert.AreEqual(expr, actr);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int a = 7, b = 7, c = 7;
            string expr = "Equilateral";
            string actr = mtl.Triangle(a, b, c);
            Assert.AreEqual(expr, actr);
        }


        [TestMethod]
        public void TestMethod4()
        {
            int a = 3, b = 3, c = 6;
            string expr = "";
            string actr = mtl.Triangle(a, b, c);
            Assert.AreEqual(expr, actr);
        }

        [TestMethod]
        public void TestMethod5()
        {
            int a = 5, b = 2, c = 2;
            string expr = "";
            string actr = mtl.Triangle(a, b, c);
            Assert.AreEqual(expr, actr);
        }

        [TestMethod]
        public void TestMethod6()
        {
            int a = 3, b = 6, c = 3;
            string expr = "";
            string actr = mtl.Triangle(a, b, c);
            Assert.AreEqual(expr, actr);
        }

        [TestMethod]
        public void TestMethod7()
        {
            int a = 0, b = 7, c = 7;
            string expr = "";
            string actr = mtl.Triangle(a, b, c);
            Assert.AreEqual(expr, actr);
        }


        [TestMethod]
        public void TestMethod8()
        {
            int a = 7, b = 0, c = 7;
            string expr = "";
            string actr = mtl.Triangle(a, b, c);
            Assert.AreEqual(expr, actr);
        }

        [TestMethod]
        public void TestMethod9()
        {
            int a = 7, b = 7, c = 0;
            string expr = "";
            string actr = mtl.Triangle(a, b, c);
            Assert.AreEqual(expr, actr);
        }
    }
}
