/* Задача 55: Задайте двумерный массив. Напишите программу,
которая заменяет строки на столбцы. В случае, если это
невозможно, программа должна вывести сообщение для
пользователя. */
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

int element = 0;
if (mass.GetLength(0) == mass.GetLength(1))
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j =i+1; j <mass.GetLength(1); j++)
        {
            element = mass[i, j];
            mass[i, j] = mass[j, i];
            mass[j, i] = element;
            //Console.Write(mass[0, j] + " ");
            //else Console.WriteLine("Нет");
            //Console.Write(mass[mass.GetLength(0) - 1, j] + " ");  
        }
    }
    Console.WriteLine();
}
else Console.WriteLine("Нет");
Print(mass);
Console.WriteLine();
