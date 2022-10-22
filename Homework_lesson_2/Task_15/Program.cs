// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write ("Please enter digit 1 to 7: ");
int number = int.Parse(Console.ReadLine());

if (number == 6 || number == 7)
    Console.Write ("It's weekend!");
else
    Console.Write ("It's not weekend!");