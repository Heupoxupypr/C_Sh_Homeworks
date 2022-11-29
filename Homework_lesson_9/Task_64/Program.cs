//  Задайте значение N. Напишите программу, которая выведет 
//  все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int GetNumber(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine() ?? "");
    return result;
}

void RecursOutput(int n)
{
    if (n == 1)
        Console.Write(n);
    else
    {
        Console.Write(n + " ");
        RecursOutput(--n);
    }
}

int n = GetNumber("Please enter N:");
RecursOutput(n);
Console.WriteLine();