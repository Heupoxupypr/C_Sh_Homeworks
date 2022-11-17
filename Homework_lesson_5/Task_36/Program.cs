// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

//Функция получения от пользователя числа
int GetDigit(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine() ?? "");
}

//Функция заполнения массива случайными числами
int[] InitArray()
{
    int[] result = new int[GetDigit("Please enter count of elements in array:")];
    Random rnd = new Random();
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(-999, 1000);
    }

    return result;
}


//Функция вывода массива на экран
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

//Функция подсчета суммы элементов, стоящих на нечетных пощисиях в массиве
int CountSumOddPosEls(int[] array)
{
    int SumOddPosEls = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((i % 2) != 0)
            SumOddPosEls += array[i];
    }
    return SumOddPosEls;
}


int[] array = InitArray();
PrintArray(array);


Console.WriteLine($"Summ of elements on odd position in array: {CountSumOddPosEls(array)}");