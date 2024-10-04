using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace KiemThuHopDen
{
    [TestClass]
    public class Bai05DD
    {
        public TestContext TestContext { get; set; }
        MethodLibrary.MethodLibrary mtl = new MethodLibrary.MethodLibrary();

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", 
            "|DataDirectory|\\datab5.csv", 
            "data#csv", DataAccessMethod.Sequential), 
            DeploymentItem("datab5.csv"), TestMethod]
        public void TestMethod()
        {
            string num = TestContext.DataRow[0].ToString();
            string typeResult = TestContext.DataRow[1].ToString();
            if (typeResult == "Exception")
            {
                Exception e = null;
                try
                {
                    mtl.BinToDec(num);
                }
                catch (Exception e1)
                {
                    e = e1;
                }

                Assert.IsNotNull(e);
            }
            else
            {
                int expectedResult = int.Parse(typeResult);
                int actualResult = mtl.BinToDec(num);
                Assert.AreEqual(expectedResult, actualResult);
            }

        }

    }
}