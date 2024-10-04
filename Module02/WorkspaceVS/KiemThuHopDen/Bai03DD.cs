using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace KiemThuHopDen
{
    [TestClass]
    public class Bai03DD
    {
        public TestContext TestContext { get; set; }
        MethodLibrary.MethodLibrary mtl = new MethodLibrary.MethodLibrary();

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", 
            "|DataDirectory|\\datab3.csv", 
            "data#csv", DataAccessMethod.Sequential), 
            DeploymentItem("datab3.csv"), TestMethod]
        public void TestMethod()
        {
            int num = int.Parse(TestContext.DataRow[0].ToString());
            string typeResult = TestContext.DataRow[1].ToString();
            if (typeResult == "Exception")
            {
                Exception e = null;
                try
                {
                    mtl.primeCheck(num);
                }
                catch (Exception e1)
                {
                    e = e1;
                }

                Assert.IsNotNull(e);
            } else
            {
                bool expectedResult = (typeResult == "TRUE");
                bool actualResult = mtl.primeCheck(num);
                Assert.AreEqual(expectedResult, actualResult);
            }
        }

    }
}