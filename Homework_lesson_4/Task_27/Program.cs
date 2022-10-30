//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

//проверка введенной информации
int CheckInput (string message)
{
    int result;

    while (true)
    {
        Console.WriteLine(message);
        
        if (int.TryParse(Console.ReadLine()?? "", out int number) && number != 0)
        {
            result = number;
            break;
        }
        else
        {
            Console.WriteLine("You enter not digit. Please repeat your enter\n");
        }
    }

    return result;
}

int SumDigits (int number)
{
    int sum = 0;
    int div = 10;

    while (number != 0)
    {
        sum += number % div;
        number /= div;
    }

    return sum;
}

int number = CheckInput("Please enter number:   ");
Console.WriteLine ($"Summ all digits in number {number} is {SumDigits(number)}");