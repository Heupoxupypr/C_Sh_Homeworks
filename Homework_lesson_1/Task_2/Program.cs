// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write ("Please enter first number: ");
string number_1Str = Console.ReadLine();
Console.Write ("Please enter second number: ");
string number_2Str = Console.ReadLine();

int number_1 = int.Parse(number_1Str);
int number_2 = int.Parse(number_2Str);

if (number_1 == number_2)
{
    Console.WriteLine ("Both numbers are equal");
}
else if (number_1 > number_2)
{
    Console.WriteLine ($"{number_1} greater than the {number_2}");
}
else
{
    Console.WriteLine ($"{number_2} greater than the {number_1}");
}