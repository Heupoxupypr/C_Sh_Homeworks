// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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
        result[i] = rnd.Next(100, 1000);
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

//Функция подсчета четных элементов массива
int CountParity(int[] array)
{
    int ParityCount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i] % 2) == 0)
            ParityCount++;
    }
    return ParityCount;
}


int[] array = InitArray();
PrintArray(array);


Console.WriteLine($"Count of parity elements: {CountParity(array)}");

