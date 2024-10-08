﻿using Tyuiu.BaimuhametovaMD.Sprint1.Task6.V5.Lib;

//Написать программу: пользователь вводит текст. Напечатать те слова,
//которые являются симметричными (например: казак, шалаш).

namespace Tyuiu.BaimuhametovaMD.Sprint1.Task6.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Баймухаметова М.Д. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Работа со строками, класс String                                  *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Баймухаметова Мадина | ИБКСб-24-1                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу: пользователь вводит текст. Напечатать те слова,     *");
            Console.WriteLine("* которые являются симметричными (например: казак, шалаш).                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите текст:");
            string text = new String(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Симметричные слова: " + ds.CheckSymmetricalWords(text));
            Console.ReadLine();
        }
    }
}
