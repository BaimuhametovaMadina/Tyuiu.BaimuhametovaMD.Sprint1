using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.BaimuhametovaMD.Sprint1.Task4.V2.Lib
{
    public class DataService: ISprint1Task4V2
    {
        public double Calculate(double x, double y)
        {
            return Math.Round(1 / Math.Sqrt(x + 2 * y), 3);
        }
    }
}
