// Максимальное из трех чисел
using System;
namespace Task4
{
    class Programm
    {
        static void Main()
        {
        Console.WriteLine("Введите число a");
        int a =  Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число b");
        int b =  Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число c");
        int c =  Convert.ToInt32(Console.ReadLine());
        int max = a;
        if (max < b) {max = b;}
        if (max < c) {max = c;}
        Console.Write($"Максимальное число равно = {max}");
        }
    }
}

