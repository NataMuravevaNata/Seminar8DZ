// Сформировать трехмерный массив не повторяющимися двузначными числами 
//показать его построчно на экран выводя индексы соответствующего элемента

void FillArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = new Random().Next(10, 100);
            }
        }
    }
}
void PrintArray(int[,,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            for (int p = 0; p < array.GetLength(2); p++)
            {
                Console.Write($"({m},{n},{p}) = {array[m, n, p]}   ");
            }
        }
        Console.WriteLine();
    }
}

Console.Write("Bведите m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Bведите n: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Bведите p: ");
int p = int.Parse(Console.ReadLine());
int[,,] matrix = new int[m, n, p];
FillArray(matrix);
Console.WriteLine("Трехмерный массив: ");
PrintArray(matrix);
Console.WriteLine();

