// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetNumber(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine() ?? "");
    return result;
}

int RecursSumOutput(int m, int n)
{
    if (m == n)
        return m;
    
    return m + RecursSumOutput(++m, n);
}

int m = GetNumber("Please enter M:");
int n = GetNumber("Please enter N:");
Console.WriteLine();
Console.WriteLine("Sum of natural elements in the range from M to N: " + RecursSumOutput(m, n));