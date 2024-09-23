using Tyuiu.BaimuhametovaMD.Sprint1.Task3.V5.Lib;

//Написать программу вычисления расстояния между населенными пунктами, изображенными на карте. Ответ округлите до 3 знаков после запятой.

//Масштаб карты(количество км. в одном см.) -> 120

//Расстояние между точками, изображающими населенные пункты (см) -> 3.5

//Расстояние между населенными пунктами 420 км.

namespace Tyuiu.BaimuhametovaMD.Sprint1.Task3.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Баймухаметова М.Д. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Арифметические операторы в C#                                     *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Баймухаметова Мадина | ИБКСб-24-1                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РАСЧЕТЫ:                                                                *");
            Console.WriteLine("* Написать программу вычисления расстояния между населенными пунктами,    *");
            Console.WriteLine("* изображенными на карте. Ответ округлите до 3 знаков после запятой.      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите масштаб карты (количество км. в одном см.):");
            double mapScale = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите расстояние между точками, изображающими населенные пункты (см):");
            double pointsDistance = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Расстояние между населенными пунктами: " + ds.DistanceLength(mapScale, pointsDistance) + " км");
            Console.ReadLine();
        }
    }
}
