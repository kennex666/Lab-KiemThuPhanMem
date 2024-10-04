using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace KiemThuHopDen
{
    [TestClass]
    public class Bai09DD
    {
        public TestContext TestContext { get; set; }
        MethodLibrary.MethodLibrary mtl = new MethodLibrary.MethodLibrary();

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", 
            "|DataDirectory|\\datab9.csv", 
            "data#csv", DataAccessMethod.Sequential), 
            DeploymentItem("datab9.csv"), TestMethod]
        public void TestMethod()
        {
            {
                int s0 = int.Parse(TestContext.DataRow[0].ToString());
                int expectedResult = int.Parse(TestContext.DataRow[2].ToString());

                long actualResult = 0;
                ml.Sum(s0, out actualResult);
                Assert.AreEqual(expectedResult, actualResult);
            }

    }
}