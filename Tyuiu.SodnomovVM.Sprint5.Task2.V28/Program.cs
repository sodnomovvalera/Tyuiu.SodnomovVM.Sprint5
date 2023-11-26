using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SodnomovVM.Sprint5.Task2.V28.Lib;

namespace Tyuiu.SodnomovVM.Sprint5.Task2.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mtrx = new int[3, 3] { { -5, -2, -5 }, { 3, 1, -3 }, { 9, -2, -9 } };
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Содномов В.М. | СмартБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнил: Содномов Валерий Михайлович | СмартБ-23-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, которая суммирует значения двух    *");
            Console.WriteLine("* одинаковых массивов по длинне.                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(mtrx);
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Файл:" + res);
            Console.ReadKey();
        }
    }
}
