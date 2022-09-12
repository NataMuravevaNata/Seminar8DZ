// В двумерном массиве целых чисел. 
//Удалить строку и столбец, на пересечении которых расположен наименьший элемент.

void FillArray(int[,] array, int min, int max)
{
    for (int i = 0; i <= array.GetLength(0); i++)
        for (int j = 0; j <= array.GetLength(1); j++)
            array[i, j] = new Random().Next(min, max);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i <= array.GetLength(0); i++)
    {
        for (int j = 0; j <= array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine(" ");
    }
}
Console.WriteLine("Введите m");
int m = int.Parse(Console.ReadLine());
Console.WriteLine(" ");
Console.WriteLine("Введите n");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(" ");

int[,] array = new int[m, n];
FillArray(array, 1, 10);
PrintArray(array);

int namberMin = array[0, 0];
int minM = 0;
int minN = 0;
for (int i = 0; i <= array.GetLength(0); i++)
    for (int j = 0; j <= array.GetLength(1); j++)
        if (array[i, j] < namberMin)
        {
            namberMin = array[i, j];
            minM = i;
            minN = j;
        }
for (int i = minM; i < array.GetLength(0); i++)
    for (int j = 0; j <= array.GetLength(1); j++)
        array[i, j] = array[i + 1, j];
for (int i = minN; i < array.GetLength(1); i++)
    for (int j = 0; j <= array.GetLength(0); j++)
        array[j, i] = array[j, i + 1];

int[,] newArray = new int[array.GetLength(0), array.GetLength(1)];
for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
        newArray[i, j] = array[i, j];

PrintArray(newArray);

