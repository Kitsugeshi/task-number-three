using System;

namespace task_number_three
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)//поподает ли точка на территорию радиуса единичной окружности или нет
            {
                Console.WriteLine("Введите значение по x: ");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите значение по y: ");
                double y = Convert.ToDouble(Console.ReadLine());

                if (x*x + y*y <= 1)
                {
                    Console.WriteLine("Принадлежит окружности.");
                }
                else
                {
                    Console.WriteLine("Не принадлежит окружности.");
                }   
            }
        }
    }
}
