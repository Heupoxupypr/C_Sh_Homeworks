// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write ("Please enter number: ");
int number = int.Parse(Console.ReadLine()) /100;

if (number > 0 )
    Console.WriteLine ($"Third digit of the number {number % 10}");
else 
    Console.WriteLine ($"Third digit of the number is NOT");