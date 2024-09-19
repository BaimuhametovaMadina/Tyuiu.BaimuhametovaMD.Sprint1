using Tyuiu.BaimuhametovaMD.Sprint1.Task2.V4.Lib;

namespace Tyuiu.BaimuhametovaMD.Sprint1.Task2.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 4;
            var res = ds.CalculateSquare(x);
            Assert.AreEqual(16, res);
        }
    }
}