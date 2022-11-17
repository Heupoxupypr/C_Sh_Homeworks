// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

//Функция получения от пользователя числа
int GetDigit(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine() ?? "");
}

//Функция заполнения массива случайными числами
double[] InitArray()
{
    double[] result = new double[GetDigit("Please enter count of elements in array:")];
    Random rnd = new Random();
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.NextDouble() + rnd.Next(-999, 1000);
    }

    return result;
}


//Функция вывода массива на экран
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

//Функция подсчета разницы между максимальным и минимальным числами в массиве
double DiffMaxMin(double[] array)
{
    double max = array[0], min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
        
        if (array[i] < min)
            min = array[i];
    }
    
    return max - Math.Abs(min); //минимальное число взято по модулю чтобы не было ошибки 
                                // если минимальное число отрицательное
}


double[] array = InitArray();
PrintArray(array);


 Console.WriteLine($"Difference of max and min elements in array: {DiffMaxMin(array)}");