// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

//Функция получения от пользователя чисел
int GetDigits(string message)
{
    int PositiveCount = 0;
    Console.WriteLine(message);
    int m = int.Parse(Console.ReadLine() ?? "");

    Console.WriteLine($"Please enter {m} numbers: ");

    for (int i = 0; i < m; i++)
    {
        if (int.Parse(Console.ReadLine() ?? "") > 0)
            PositiveCount++;
    }
    return PositiveCount;
}

Console.WriteLine($"User enter {GetDigits("Please enter count of numbers to enter")} positive numbers.");