using Tyuiu.BaimuhametovaMD.Sprint1.Task4.V2.Lib;

namespace Tyuiu.BaimuhametovaMD.Sprint1.Task4.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculationValid()
        {
            DataService ds = new DataService();
            double x = 2, y = 1;
            Assert.AreEqual(0.5, ds.Calculate(x, y));
        }
    }
}