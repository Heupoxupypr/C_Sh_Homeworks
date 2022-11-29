// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int GetNumber(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine() ?? "");
    return result;
}

int RecursAckermanFunc(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m > 0) && (n == 0))
    {
        return RecursAckermanFunc(m - 1, 1);
    }
    else 
    {
        return RecursAckermanFunc(m - 1, RecursAckermanFunc(m, n - 1));
    }
}

int m = GetNumber("Please enter M:");
int n = GetNumber("Please enter N:");
Console.WriteLine();
Console.WriteLine("Ackerman funct M to N: " + RecursAckermanFunc(m, n));