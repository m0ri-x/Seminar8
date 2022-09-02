// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3

// Результирующая матрица будет:
// 18 20
// 15 18

int[,] FillMatrix(int rowsCount, int columnsCount, int leftRange = 0, int rightRange = 9)
{
    int[,] matrix = new int[rowsCount, columnsCount];

    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введиче количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix1 = FillMatrix(m, n);
int[,] matrix2 = FillMatrix(m, n);

Console.WriteLine("Первая матрица: ");
PrintMatrix(matrix1);
Console.WriteLine("Вторая матрица: ");
PrintMatrix(matrix2);
Console.WriteLine("Произведение элементов двух матриц: ");

int[,] matrixProduct = matrixProduct = new int[m, n];
for (int i = 0; i < matrixProduct.GetLength(0); i++)
{
    for (int j = 0; j < matrixProduct.GetLength(1); j++)
    {
       matrixProduct[i, j] = matrix1[i, j] * matrix2[i, j];
    };
}

PrintMatrix(matrixProduct); 