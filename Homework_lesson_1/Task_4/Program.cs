// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write ("Please enter first number: ");
string number_1Str = Console.ReadLine();
Console.Write ("Please enter second number: ");
string number_2Str = Console.ReadLine();
Console.Write ("Please enter third number: ");
string number_3Str = Console.ReadLine();

int number_1 = int.Parse(number_1Str);
int number_2 = int.Parse(number_2Str);
int number_3 = int.Parse(number_3Str);

int max = 0;

if (number_1 == number_2)
{
    max = number_1;
}
else if (number_1 > number_2)
{
    max = number_1;
}
else
{
    max = number_2;
}

if (max == number_3)
{
    Console.WriteLine ($"Maximum = {max}");
}
else if (max > number_3)
{
    Console.WriteLine ($"Maximum = {max}");
}
else
{
    Console.WriteLine ($"Maximum = {number_3}");
}