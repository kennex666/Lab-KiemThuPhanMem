using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace KiemThuHopDen
{
    [TestClass]
    public class Bai08DD
    {
        public TestContext TestContext { get; set; }
        MethodLibrary.MethodLibrary mtl = new MethodLibrary.MethodLibrary();

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", 
            "|DataDirectory|\\datab8.csv", 
            "data#csv", DataAccessMethod.Sequential), 
            DeploymentItem("datab8.csv"), TestMethod]
        public void TestMethod()
        {
            {
                int a = int.Parse(TestContext.DataRow[0].ToString());
                int b = int.Parse(TestContext.DataRow[1].ToString());
                double expectedResult = double.parse(TestContext.DataRow[2].ToString());
                string actualResult = mtl.TinhTienDien(a, b);
                Assert.AreEqual(expectedResult, actualResult);
            }

    }
}