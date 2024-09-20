using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KiemThuHopDen
{
    [TestClass]
    public class Bai08
    {
        MethodLibrary.MethodLibrary mtl = new MethodLibrary.MethodLibrary();

        [TestMethod]
        public void TestMethod1()
        {
            int chiSoCu = 25;
            int chiSoMoi = 50;
            double e = 40810;
            double a = mtl.TinhTienDien(chiSoCu, chiSoMoi);

            Assert.AreEqual(e, a, 1);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int chiSoCu = 25;
            int chiSoMoi = 76;
            double e = 83306;
            double a = mtl.TinhTienDien(chiSoCu, chiSoMoi);

            Assert.AreEqual(e, a, 1);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int chiSoCu = 25;
            int chiSoMoi = 176;
            double e = 266130;
            double a = mtl.TinhTienDien(chiSoCu, chiSoMoi);

            Assert.AreEqual(e, a, 1);
        }

        [TestMethod]
        public void TestMethod4()
        {
            int chiSoCu = 25;
            int chiSoMoi = 276;
            double e = 455226;
            double a = mtl.TinhTienDien(chiSoCu, chiSoMoi);

            Assert.AreEqual(e, a, 1);
        }

        [TestMethod]
        public void TestMethod5()
        {
            int chiSoCu = 25;
            int chiSoMoi = 376;
            double e = 527893;
            double a = mtl.TinhTienDien(chiSoCu, chiSoMoi);

            Assert.AreEqual(e, a, 1);
        }

        [TestMethod]
        public void TestMethod6()
        {
            int chiSoCu = 25;
            int chiSoMoi = 525;
            double e = 809710;
            double a = mtl.TinhTienDien(chiSoCu, chiSoMoi);

            Assert.AreEqual(e, a, 1);
        }

        [TestMethod]
        public void TestMethod7()
        {
            int chiSoCu = -2;
            int chiSoMoi = 50;
            double e = -1;
            double a = mtl.TinhTienDien(chiSoCu, chiSoMoi);

            Assert.AreEqual(e, a, 1);
        }

        [TestMethod]
        public void TestMethod8()
        {
            int chiSoCu = 25;
            int chiSoMoi = -50;
            double e = -1;
            double a = mtl.TinhTienDien(chiSoCu, chiSoMoi);

            Assert.AreEqual(e, a, 1);
        }


        [TestMethod]
        public void TestMethod9()
        {
            int chiSoCu = 50;
            int chiSoMoi = 25;
            double e = -1;
            double a = mtl.TinhTienDien(chiSoCu, chiSoMoi);

            Assert.AreEqual(e, a, 1);
        }

        [TestMethod]
        public void TestMethod10()
        {
            int chiSoCu = 0;
            int chiSoMoi = 25;
            double e = 40810;
            double a = mtl.TinhTienDien(chiSoCu, chiSoMoi);

            Assert.AreEqual(e, a, 1);
        }
        [TestMethod]
        public void TestMethod11()
        {
            int chiSoCu = 0;
            int chiSoMoi = 0;
            double e = 0;
            double a = mtl.TinhTienDien(chiSoCu, chiSoMoi);

            Assert.AreEqual(e, a, 1);
        }
        [TestMethod]
        public void TestMethod12()
        {
            int chiSoCu = -1;
            int chiSoMoi = 50;
            double e = -1;
            double a = mtl.TinhTienDien(chiSoCu, chiSoMoi);

            Assert.AreEqual(e, a, 1);
        }
        [TestMethod]
        public void TestMethod13()
        {
            int chiSoCu = 25;
            int chiSoMoi = -1;
            double e = -1;
            double a = mtl.TinhTienDien(chiSoCu, chiSoMoi);

            Assert.AreEqual(e, a, 1);
        }
    }
}
