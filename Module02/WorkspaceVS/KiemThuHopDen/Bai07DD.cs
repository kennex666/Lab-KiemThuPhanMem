using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace KiemThuHopDen
{
    [TestClass]
    public class Bai07DD
    {
        public TestContext TestContext { get; set; }
        MethodLibrary.MethodLibrary mtl = new MethodLibrary.MethodLibrary();

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", 
            "|DataDirectory|\\datab7.csv", 
            "data#csv", DataAccessMethod.Sequential), 
            DeploymentItem("datab7.csv"), TestMethod]
        public void TestMethod()
        {
            {
                float x1, x2;
                int a = int.Parse(TestContext.DataRow[0].ToString());
                int b = int.Parse(TestContext.DataRow[1].ToString());
                int c = int.Parse(TestContext.DataRow[2].ToString());
                string expectedResult = TestContext.DataRow[3].ToString();
                string actualResult = mtl.SolveQuadratic(a, b, c, out x1, out x2);
                Assert.AreEqual(expectedResult, actualResult);
            }

    }
}