// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

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

int a = CheckInput ("Please enter number A: ");
int b = CheckInput ("Please enter number B: ");

Console.WriteLine ($"Result: {Math.Pow(a,b)}");
