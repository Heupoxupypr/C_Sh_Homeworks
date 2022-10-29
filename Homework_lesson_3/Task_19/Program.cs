// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write ("Please enter number: ");
int number = int.Parse(Console.ReadLine());

if ((number / 10000) == (number % 10) &&
    ((number / 1000) % 10) == ((number % 100) / 10))
{
    Console.WriteLine ($"Number {number} is palindrome");
}
else
{
    Console.WriteLine ($"Number {number} is NOT palindrome");
}