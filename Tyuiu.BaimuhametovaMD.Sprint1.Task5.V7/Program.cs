using Tyuiu.BaimuhametovaMD.Sprint1.Task5.V7.Lib;

//Определить h – полное количество часов прошедших от начала суток до того момента (в первой половине дня),
//когда часовая стрелка повернулась на f градусов (0<f<360, f – вещественное число).

namespace Tyuiu.BaimuhametovaMD.Sprint1.Task5.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Баймухаметова М.Д. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Баймухаметова Мадина | ИБКСб-24-1                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая решает следующую задачу:                    *");
            Console.WriteLine("* Определить h – полное количество часов прошедших от начала суток        *");
            Console.WriteLine("* до того момента (в первой половине дня),                                *");
            Console.WriteLine("* когда часовая стрелка повернулась на f градусов                         *");
            Console.WriteLine("* (0<f<360, f – вещественное число).                                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите величину угла f:");
            double f = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Часов прошло: " + ds.AngleToHoursMinutes(f));
            Console.ReadLine();
        }
    }
}
