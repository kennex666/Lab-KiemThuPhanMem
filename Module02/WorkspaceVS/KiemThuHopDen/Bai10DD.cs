using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace KiemThuHopDen
{
    [TestClass]
    public class Bai10DD
    {
        public TestContext TestContext { get; set; }
        MethodLibrary.MethodLibrary mtl = new MethodLibrary.MethodLibrary();

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", 
            "|DataDirectory|\\datab10.csv", 
            "data#csv", DataAccessMethod.Sequential), 
            DeploymentItem("datab10.csv"), TestMethod]
        public void TestMethod()
        {
            {
                int s0 = int.Parse(TestContext.DataRow[0].ToString());
                int expectedResult = int.Parse(TestContext.DataRow[2].ToString());


                int n = int.Parse(TestContext.DataRow[1].ToString()),
                        p = int.Parse(TestContext.DataRow[2].ToString());
                string s = TestContext.DataRow[0].ToString();
                string expectedResult = TestContext.DataRow[3].ToString();
                string actualResult = ml.HuyChuoi(s, n, p);

                Assert.AreEqual(expectedResult, actualResult);
            }

        }
}