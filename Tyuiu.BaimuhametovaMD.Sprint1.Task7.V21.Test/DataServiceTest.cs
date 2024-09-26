using Tyuiu.BaimuhametovaMD.Sprint1.Task7.V21.Lib;

namespace Tyuiu.BaimuhametovaMD.Sprint1.Task7.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculationValid()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(-2.314, res);
        }
    }
}