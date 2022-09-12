// Найти произведение двух матриц
void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] FindMatrixes(int[,] matrix1, int[,] matrix2)
{
    int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
                matrix3[i, j] += matrix1[i, k] * matrix2[k, j];
        }
    }
    return matrix3;
}
Console.Clear();
Console.Write("Кол-во строк первой матрицы: ");
int i1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Кол-во столбцов первой матрицы: ");
int j1 = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix11 = new int[i1, j1];
Console.Write("Кол-во строк второй матрицы: ");
int i2 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Кол-во столбцов второй матрицы: ");
int j2 = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix22 = new int[i2, j2];
if (i1 != j2) Console.Write("Кол-во строк первой матрицы не равно кол-ву столбцов второй");
else if (j1 != i2) Console.Write("Кол-во столбцов первой матрицы не равно кол-ву строк второй!");
else
{
    FillArray(matrix11);
    FillArray(matrix22);
    Console.WriteLine("Матрица 1:");
    PrintArray(matrix11);
    Console.WriteLine("Матрица 2:");
    PrintArray(matrix22);
    Console.WriteLine("Произведение матриц:");
    PrintArray((FindMatrixes(matrix11, matrix22)));
}