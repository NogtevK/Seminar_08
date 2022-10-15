/* Задача 59: Задайте двумерный массив из целых чисел. Напишите
программу, которая удалит строку и столбец, на пересечении которых
расположен наименьший элемент массива.
 */
void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int m = 4, n = 4;
int[,] mass = new int[m, n];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(0, 10);
    }
}
Print(mass);
Console.WriteLine();

int min = mass[0, 0];
int minx = 0;// координаты макс
int miny = 0; //мин координаты

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        if (mass[i, j] < min)
        {
            min = mass[i, j];
            minx = i;
            miny = j;
        }
    }
}
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        if (i != minx && j != miny)
            Console.Write(mass[i, j] + " ");
    }
    if (i != minx)
        Console.WriteLine();
}