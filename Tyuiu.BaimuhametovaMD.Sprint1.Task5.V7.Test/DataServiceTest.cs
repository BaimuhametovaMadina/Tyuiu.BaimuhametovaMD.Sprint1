using Tyuiu.BaimuhametovaMD.Sprint1.Task5.V7.Lib;

namespace Tyuiu.BaimuhametovaMD.Sprint1.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculationValid()
        {
            DataService ds = new DataService();
            double f = 121;
            int res = ds.AngleToHoursMinutes(f);
            Assert.AreEqual(4, res);
        }
    }
}