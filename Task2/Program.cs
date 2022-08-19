// Максимальное из двух чисел
using System;
namespace Task2
{
    class Programm
    {
        static void Main()
        {
        Console.WriteLine("Введите число a");
        int a =  Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число b");
        int b =  Convert.ToInt32(Console.ReadLine());
        int max = a;
        if (a < b) {max = b;}
        Console.Write($"Максимальное число равно = {max}");
        }
    }
}



