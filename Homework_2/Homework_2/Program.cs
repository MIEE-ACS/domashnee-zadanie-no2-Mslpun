using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


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
        static double segment3(double x)
        {
            double y = -2;
            return y;
        }
        static double segment4(double x, double r)
        {
            double y = -2 + Math.Sqrt(Math.Pow(r, 2) - Math.Pow((x - 8), 2));
            return y;
            
        }
        static void Main(string[] args)
        {
            Console.Write("Введите параметр r: ");
            double r = double.Parse(Console.ReadLine());
            for (double x = -4; x <= 8 + r; x = x + 0.2)
            {
                if (x < -2)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment1(x));
                }
                else if (x < 4)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment2(x));
                }
                else if (x >= 4 && x <= 8.3 + r)
                {
                    if (x < 6.2)
                    {
                        Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment3(x));
                    }
                    if (x>=6 && x < 10 )
                    {
                        Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment4(x, r));
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
