using Tyuiu.BaimuhametovaMD.Sprint1.Task6.V5.Lib;

namespace Tyuiu.BaimuhametovaMD.Sprint1.Task6.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckMethodValid()
        {
            DataService ds = new DataService();
            string text = "Казак помыл машину, его шалаш упал, каак";
            string res = ds.CheckSymmetricalWords(text);
            Assert.AreEqual("казак, шалаш, каак", res);
        }
    }
}