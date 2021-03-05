using System;

namespace TRPO_Lab3.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите (R) радиус шара или образующую конуса");
            double Radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите (r) радиус основания шарового сегмента");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите (h) высоту шарового сегмента");
            double height = Convert.ToDouble(Console.ReadLine());
            if (Radius <= 0)
            {
                Console.WriteLine("Введите положительное число");
            }
            else if (radius <= 0)
            {
                Console.WriteLine("Введите положительное число");
            }
            else if (height <= 0)
            {
                Console.WriteLine("Введите положительное число");
            }
            else
            {
                TRPO_Lab3.Lib.Math_1 math_1 = new TRPO_Lab3.Lib.Math_1();
               double answer =  math_1.Formula(Radius, radius, height);
                Console.WriteLine($"Площадь поверхности шарового сектора: {answer}");
            }
            Console.ReadKey();
        }
    }
}
