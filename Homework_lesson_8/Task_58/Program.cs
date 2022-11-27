// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] InitMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
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

int [,] MatrixMultipl(int[,] matrix1, int[,] matrix2)
{
    int[,] matrix = new int[matrix1.GetLength(0),  matrix2.GetLength(1)];
    int sum = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k <  matrix2.GetLength(0); k++ )
            {
                sum += (matrix1[i,k]*matrix2[k,j]); 
            }
            matrix[i,j] = sum;
            sum = 0;// Console.Write($"{matrix[i, j]}\t");
        }
        // Console.WriteLine();
    }

    return matrix;
}

int m = GetNumber("Please enter number of rows matrix1:");
int n = GetNumber("Please enter number of columns matrix1:");
int[,] matrix1 = InitMatrix(m, n);
m = GetNumber("Please enter number of rows matrix2:");
n = GetNumber("Please enter number of columns matrix2:");
int[,] matrix2 = InitMatrix(m, n);
Console.WriteLine();
PrintMatrix(matrix1);
Console.WriteLine();
PrintMatrix(matrix2);
Console.WriteLine();

if (matrix1.GetLength(1) != matrix2.GetLength(0))
{
    Console.WriteLine("Matrix1 and Matrix2 cannot be multiplied");
}
else
{
   PrintMatrix(MatrixMultipl(matrix1,matrix2));
}
