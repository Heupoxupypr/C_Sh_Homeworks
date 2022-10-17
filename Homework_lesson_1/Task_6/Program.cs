// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Please enter number: ");
string numberStr = Console.ReadLine();

int number = int.Parse(numberStr);

if ((number % 2) == 0)
{
    Console.WriteLine("Number is EVEN!");
}
else
{
    Console.WriteLine("Number is ODD!");
}