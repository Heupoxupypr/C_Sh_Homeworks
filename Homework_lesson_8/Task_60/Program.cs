// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] InitMatrix(int y, int x, int z)
{
    int[,,] matrix = new int[y, x, z];
    int[] digits = new int[y * x * z];
    int count = 0;
    Random rnd = new Random();
    for (int k = 0; k < matrix.GetLength(2); k++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                count++;
                matrix[i, j, k] = rnd.Next(1, 100);
                for (int n = 0; n < count; n++)
                {
                    if (matrix[i, j, k] == digits[n])
                    {
                        n = 0;
                        matrix[i, j, k] = rnd.Next(1, 100);
                    }
                }
                digits[count - 1] = matrix[i, j, k];
            }
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


void PrintMatrix(int[,,] matrix)
{
    for (int k = 0; k < matrix.GetLength(2); k++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j, k]}({i}, {j}, {k})\t");
            }
            Console.WriteLine();
        }
    }
}

int l = GetNumber("Please enter number l:");
int c = GetNumber("Please enter number c:");
int z = GetNumber("Please enter number c:");
int[,,] matrix = InitMatrix(l, c, z);
PrintMatrix(matrix);
Console.WriteLine();
