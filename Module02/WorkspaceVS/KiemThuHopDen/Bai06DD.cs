using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace KiemThuHopDen
{
    [TestClass]
    public class Bai06DD
    {
        public TestContext TestContext { get; set; }
        MethodLibrary.MethodLibrary mtl = new MethodLibrary.MethodLibrary();

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", 
            "|DataDirectory|\\datab6.csv", 
            "data#csv", DataAccessMethod.Sequential), 
            DeploymentItem("datab6.csv"), TestMethod]
        public void TestMethod()
        {
            int a = int.Parse(TestContext.DataRow[0].ToString());
            int b = int.Parse(TestContext.DataRow[1].ToString());
            int c = int.Parse(TestContext.DataRow[2].ToString());
            string expectedResult = TestContext.DataRow[3].ToString();
            string actualResult = mtl.Triangle(a,b,c);
            Assert.AreEqual(expectedResult, actualResult);
            
        }

    }
}