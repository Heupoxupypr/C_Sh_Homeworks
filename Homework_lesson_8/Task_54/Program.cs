// Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] InitMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 50);
        }
    }

    return matrix;
}

int GetNumber(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine() ?? "");
    return result;
}

int[,] SortMatrix(int[,] matrix)
{
    int left_j, right_j; //Индексы слав и справа
    bool swapped = false; //флаг наличия изменений
    int replace;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        left_j = 0;
        right_j = matrix.GetLength(1) - 1;
        for (int j = left_j; j < right_j; j++)
        {
            if (matrix[i, j] < matrix[i, j + 1])
            {
                swapped = true;
                replace = matrix[i, j];
                matrix[i, j] = matrix[i, j + 1];
                matrix[i, j + 1] = replace;
            }
        }
        right_j--;
        if ((left_j < right_j) && swapped)
        {
            swapped = false;
            for (int j = right_j; j > left_j; j--)
            {
                if (matrix[i, j] > matrix[i, j - 1])
                {
                    swapped = true;
                    replace = matrix[i, j];
                    matrix[i, j] = matrix[i, j - 1];
                    matrix[i, j - 1] = replace;
                }
            }
            left_j++;
            if ((left_j == right_j) || !swapped)
                continue;
        }
        else
            continue;;
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int m = GetNumber("Введите число m:");
int n = GetNumber("Введите число n:");
int[,] matrix = InitMatrix(m, n);
PrintMatrix(matrix);
Console.WriteLine();
PrintMatrix(SortMatrix(matrix));
