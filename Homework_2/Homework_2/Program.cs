using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

// Вариант 5.
namespace Homework_2
{

    internal class Program
    {
        static double segment1(double x)
        {
            double y = x + 3;
            return y;
        }
        static double segment2(double x)
        {
            double y = -x / 2;
            return y;
        }
        static double segment4(double x, double r)
        {
            double y = -2 + Math.Sqrt(Math.Pow(r, 2) - Math.Pow((x - 8), 2));
            return y;
            
        }
        static void Main(string[] args)
        {
            Console.Write("Иванов Никита УТС-21. Вариант 5.\n");
            Console.Write("Вывести значения фукнции для промежутка от [-4;10].\nЕсли значение функции определить невозможно выводиться ошибка в данной точке.\n");
            Console.Write("Введите параметр r: ");
            double r;
            while (!double.TryParse(Console.ReadLine(), out r))
            {
                Console.WriteLine("Нужно вводить числа, а не текстовые строки.");
                Console.Write("Введите значение радиуса: ");
            }
            Console.Write("Таблица значений функции от -4 до 10 c шаком 0.2: \n");
            for (double x = -4; x <= 10; x += 0.2)
            {
                if (x < -2)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment1(x));
                }
                else if (x <= 4)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment2(x));
                }
                else if (x <= 6.1)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, -2);
                }
                else if (x >= 5.9 && x < 10 && r > 2)
                {
                    for (double a = 6; a <= 10; a += 0.2)
                    {
                        Console.WriteLine("y({0:0.00}) = {1:0.00}", a, segment4(a, r));
                    }
                    break;
                }
                else if (x > 6.1 && x < 10 && r <= 2)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment4(x, r));
                }
            }
            string e = "";
            Console.Write("Введите собственное значение аргумента, чтобы выйти введите 'no': \n");
            while (true)
            {
                if(e == "no")
                {
                    break;
                }
                Console.Write("Введите значение аргумента:");
                double x;

                while (!double.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("Нужно вводить числа, а не текстовые строки.");
                    Console.Write("Введите значение аргумента: ");
                }
                if (x >= -4 && x <= 10)
                {
                    if (x < -2)
                    {
                        Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment1(x));
                    }
                    else if (x <= 4)
                    {
                        Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment2(x));
                    }
                    else if (x <= 6)
                    {
                        Console.WriteLine("y({0:0.00}) = {1:0.00}", x, -2);
                    }

                    if (x >= 6 && x < 10 && r > 2)
                    {

                        Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment4(x, r));

                    }
                    else if (x > 6 && x < 10 && r <= 2)
                    {
                        Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment4(x, r));
                    }
                }
                else
                {
                    Console.Write("Вы вышли за пределы определяемого участка.\n");
                }
                    Console.Write("Продолжить?\nВыйти - 'no'. Продолжить - любое значение.\n");
                    e = Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
