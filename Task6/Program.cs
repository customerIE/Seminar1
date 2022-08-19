// Определение четности числа
using System;
namespace Task6
{
    class Programm
    {
        static void Main()
        {
        Console.WriteLine("Введите число a");
        int a =  Convert.ToInt32(Console.ReadLine());
        if (a % 2==1) 
        {
            Console.Write("Число нечетное");
        }
        else
        {
            Console.Write("Число четное");
        }
        
        }
    }
}


