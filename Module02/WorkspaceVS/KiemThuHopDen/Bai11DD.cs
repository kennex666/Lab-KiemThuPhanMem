using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace KiemThuHopDen
{
    [TestClass]
    public class Bai11DD
    {
        public TestContext TestContext { get; set; }
        MethodLibrary.MethodLibrary mtl = new MethodLibrary.MethodLibrary();

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", 
            "|DataDirectory|\\datab11.csv", 
            "data#csv", DataAccessMethod.Sequential), 
            DeploymentItem("datab11.csv"), TestMethod]
        public void TestMethod()
        {
            {
                string s1 = TestContext.DataRow[0].ToString();
                string s2 = TestContext.DataRow[1].ToString();
                string s3 = TestContext.DataRow[2].ToString();
                string expectedResult = TestContext.DataRow[3].ToString();

                string actualResult = ml.ThayThe(s1, s2, s3);

                Assert.AreEqual(expectedResult, actualResult);
            }

        }
}