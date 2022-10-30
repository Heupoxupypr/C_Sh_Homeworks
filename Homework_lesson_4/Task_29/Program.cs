// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// пример из 5 элементов:
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// получить все 8 чисел за одно нажатие Enter от пользователя.подсказка: использовать метод Split();

Console.Write("Please enter array: ");
string array = Console.ReadLine() ?? "";

var sub_str = array.Split(", ");

int[] dig_arr = new int [sub_str.Length];

for (int i = 0; i < sub_str.Length; i++)
{
    dig_arr[i] = int.Parse(sub_str[i]);
    if (i == 0)
        Console.Write($"[{dig_arr[i]}, ");
    else if (i == sub_str.Length - 1)
        Console.Write($"{dig_arr[i]}]");
    else
        Console.Write($"{dig_arr[i]}, ");
}
Console.WriteLine();



