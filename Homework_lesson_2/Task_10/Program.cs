using System;

namespace Task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
            //     456 -> 5
            //     782 -> 8
            //     918 -> 1

            Console.Write ("Please enter number: ");
            int number = int.Parse(Console.ReadLine());
            
            Console.WriteLine ($"Third digit of the number {number} is {number / 10 % 10}");
           
        }
    }
}
