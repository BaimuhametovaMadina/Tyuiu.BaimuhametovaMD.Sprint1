using Tyuiu.BaimuhametovaMD.Sprint1.Task3.V5.Lib;

namespace Tyuiu.BaimuhametovaMD.Sprint1.Task3.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculationValid()
        {
            double m = 120, d = 3.5;
            DataService ds = new DataService();
            Assert.AreEqual(420, ds.DistanceLength(m, d));
        }
    }
}