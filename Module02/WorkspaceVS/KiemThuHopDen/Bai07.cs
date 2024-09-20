using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KiemThuHopDen
{
    [TestClass]
    public class Bai07
    {
        MethodLibrary.MethodLibrary mtl = new MethodLibrary.MethodLibrary();

        [TestMethod]
        public void TestMethod1()
        {
            int a = 0;
            int b = 0;
            int c = 0;
            string expr = "Vô số nghiệm";
            float x1, x2;
            string actr = mtl.SolveQuadratic(a, b, c, out x1, out x2);

            Assert.AreEqual(expr, actr);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int a = 0;
            int b = 0;
            int c = 1;
            string expr = "Vô nghiệm";
            float x1, x2;
            string actr = mtl.SolveQuadratic(a, b, c, out x1, out x2);

            Assert.AreEqual(expr, actr);
        }


        [TestMethod]
        public void TestMethod3()
        {
            int a = 0;
            int b = 1;
            int c = 1;
            string expr = "Có 1 nghiệm";
            float x1, x2;
            string actr = mtl.SolveQuadratic(a, b, c, out x1, out x2);

            Assert.AreEqual(expr, actr);
        }


        [TestMethod]
        public void TestMethod4()
        {
            int a = 1;
            int b = 4;
            int c = 1;
            string expr = "Có 2 nghiệm phân biệt";
            float x1, x2;
            string actr = mtl.SolveQuadratic(a, b, c, out x1, out x2);

            Assert.AreEqual(expr, actr);
        }


        [TestMethod]
        public void TestMethod5()
        {
            int a = 1;
            int b = 2;
            int c = 1;
            string expr = "Có nghiệm kép";
            float x1, x2;
            string actr = mtl.SolveQuadratic(a, b, c, out x1, out x2);

            Assert.AreEqual(expr, actr);
        }
        [TestMethod]
        public void TestMethod6()
        {
            int a = 1;
            int b = 3;
            int c = 4;
            string expr = "Vô nghiệm";
            float x1, x2;
            string actr = mtl.SolveQuadratic(a, b, c, out x1, out x2);

            Assert.AreEqual(expr, actr);
        }
    }
}
