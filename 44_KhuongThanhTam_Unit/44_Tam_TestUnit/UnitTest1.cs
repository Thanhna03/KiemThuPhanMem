using NUnit.Framework;
using _44_KhuongThanhTam_Unit;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _44_Tam_TestUnit
{
   [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource(
            "Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @"|DataDirectory|\Data_44_Tam\TestData_44_Tam.csv",
            "TestData_44_Tam#csv",
            DataAccessMethod.Sequential)]
        public void TC3_WithTestDataSource_44_Tam()
        {
            double num_44_Tam = double.Parse(TestContext.DataRow[0].ToString());
            double mongdoi_44_Tam = double.Parse(TestContext.DataRow[1].ToString());

            var _44_Tam_caculation = new _44_Tam_Caculation();
            double thucte_44_Tam = _44_Tam_caculation.Chon(num_44_Tam.ToString());

            Assert.AreEqual(mongdoi_44_Tam, thucte_44_Tam, 0);
        }
    }

    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TC1_TestNhiThap_44_Tam()
        {
            int mongdoi_44_Tam, thucte_44_Tam;
            // Kết quả mong đợi là 1101 
            string a_44_Tam = "1101";
            mongdoi_44_Tam = 13;
            _44_Tam_Caculation c = new _44_Tam_Caculation();
            thucte_44_Tam = c.Chon("BinaryToDecimal", a_44_Tam, 0);
            // nhap vao số thập phân 1101 
            Assert.AreEqual(mongdoi_44_Tam, thucte_44_Tam);
        }

        [Test]
        public void TC2_TestThapNhi_44_Tam()
        {
            int mongdoi_44_Tam, thucte_44_Tam;
            string a_44_Tam = "13";
            int decimalNumber = int.Parse(a_44_Tam);
            // input số nhị phân 1101 
            mongdoi_44_Tam = 1101;
            _44_Tam_Caculation c = new _44_Tam_Caculation();
            thucte_44_Tam = c.Chon("DecimalToBinary", " ", decimalNumber);
            // output kết quả mong đợi là số thập phân 13 
            Assert.AreEqual(mongdoi_44_Tam, thucte_44_Tam);
        }
    }
}