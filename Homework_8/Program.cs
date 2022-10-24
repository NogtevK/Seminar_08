/* Задача 54: Задайте двумерный массив. Напишите программу, которая
упорядочит по убыванию элементы каждой строки двумерного массива.
 */
/* 
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
int[,] mass = new int[4, 4];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(0, 10);
    }
}
Print(mass);
Console.WriteLine();

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        for (int k = 0; k < mass.GetLength(1) - 1; k++)
        {
            if (mass[i, k] < mass[i, k + 1])

            {
                int temp = mass[i, k + 1];
                mass[i, k + 1] = mass[i, k];
                mass[i, k] = temp;
            }
        }
    }
}
Print(mass);
Console.WriteLine();
 */
/* Задача 56: Задайте прямоугольный двумерный массив. Напишите
программу, которая будет находить строку с наименьшей суммой элементов.
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
int[,] mass = new int[3, 4];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(0, 10);
    }
}
Print(mass);
Console.WriteLine();

int minRowSum = int.MaxValue;
int indexMinRow = 0;

for (int i = 0; i < mass.GetLength(0); i++)
{
    int rowSum = 0;
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        rowSum += mass[i, j];
    }
    if (rowSum < minRowSum)
    {
        minRowSum = rowSum;
        indexMinRow = i;
    }
}
Console.WriteLine("Строка с минимальной суммой элементов");
for (int j = 0; j < mass.GetLength(1); j++)
{
    Console.Write(mass[indexMinRow, j] + " ");
}
Console.WriteLine();