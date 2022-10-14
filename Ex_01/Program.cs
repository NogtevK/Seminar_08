/* Задача 53: Задайте двумерный массив. Напишите программу,
которая поменяет местами первую и последнюю строку
массива.
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
int m = 3, n = 4;
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
int element = 0;
for (int j = 0; j < mass.GetLength(1); j++)
{
    element = mass[0, j];
    mass[0, j] = mass[mass.GetLength(0) - 1, j];
    mass[mass.GetLength(0) - 1, j] = element;

    //Console.Write(mass[0, j] + " ");
    //Console.Write(mass[mass.GetLength(0) - 1, j] + " ");
}
Console.WriteLine();
Print(mass);