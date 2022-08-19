// Определение четных числе от 1 до N
using System;
namespace Task6
{
    class Programm
    {
        static void Main()
        {
        Console.WriteLine("Введите любое число ");
        int a =  Convert.ToInt32(Console.ReadLine());
        int  i = 0;
        while (i < a)
        {
            i +=2;
            if (i <= a) 
            {
                Console.Write(i);
            }
            
        }
        
        
        }
    }
}



