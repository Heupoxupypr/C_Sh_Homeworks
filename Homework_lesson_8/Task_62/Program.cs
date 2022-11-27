// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] SnakeInitMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    int count = 1, i = 0, j = 0, x = 0, y = 0;
    Array.Clear(matrix);

    while (true)
    {
        if (matrix[i, j] == 0)
        {
            while (j < (matrix.GetLength(1) - x))
            {
                matrix[i, j] = count;
                count++;
                j++;
            }
            i++;
            j--;
        }
        else
            break;

        if (matrix[i, j] == 0)
        {
            while (i < (matrix.GetLength(0) - y))
            {
                matrix[i, j] = count;
                count++;
                i++;
            }
            j--;
            i--;
        }
        else
            break;

        if (matrix[i, j] == 0)
        {
            while (j >= (0 + x))
            {
                matrix[i, j] = count;
                count++;
                j--;
            }
            i--;
            j++;
        }
        else
            break;

        if (matrix[i, j] == 0)
        {
            while (i >= (1 + y))
            {
                matrix[i, j] = count;
                count++;
                i--;
            }
            j++;
            i++;
        }
        else
            break;

        x++;
        y++;
    }
    return matrix;
}

int GetNumber(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine() ?? "");
    return result;
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

int m = GetNumber("Please enter number of rows:");
int n = GetNumber("Please enter number of columns:");
int[,] matrix = SnakeInitMatrix(m, n);
Console.WriteLine();
PrintMatrix(matrix);