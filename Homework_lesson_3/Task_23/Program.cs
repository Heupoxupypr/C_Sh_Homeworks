// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write ("Please enter number: ");
int number = int.Parse(Console.ReadLine());


Console.Write ($"Table of cubes for number {number} ->  ");

for (int i = 1; i <= number; i++)
{
    if (i == 1)
    {
        Console.Write ($"{Math.Pow(i, 3)}");
    }
    else
    {
        Console.Write ($", {Math.Pow(i, 3)}");
    }
}

Console.WriteLine();