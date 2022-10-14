/* Задача 57: Составить частотный словарь элементов
двумерного массива. Частотный словарь содержит
информацию о том, сколько раз встречается элемент
входных данных.
25 мин
Набор данных Частотный массив
{ 1, 9, 9, 0, 2, 8, 0, 9 } 0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза
1, 2, 3
4, 6, 1
2, 1, 6
1 встречается 3 раза
2 встречается 2 раз
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза */

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

int count = 0;    //счетчик повторений переменной "а"
int a = 0; // переменная для поиска в массиве
int[] uniq = new int[mass.Length];
int k = 0; // счетчик уникальных чисел
bool finded = false;
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {

        finded = false;
        for (int l = 0; l < k; l++)
        {
            if (mass[i, j] == uniq[l])
            {
                finded = true;
            }
        }
        if (!finded)
        {
            uniq[k] = mass[i, j];
            k++;
        }
    }
}
for (int j = 0; j < k; j++)
{
    Console.Write(uniq[j] + " ");
}
Console.WriteLine();
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; i < mass.GetLength(1); i++)
    {
        if (mass[i, j] == a)
        {
            count++;
        };
    }
}
Console.WriteLine(count);
Console.WriteLine();
for (int z = 0; z < k; z++)
{
    count = 0;
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
            if (mass[i, j] == uniq[z])
            {
                count++;
            };
    }
    Console.WriteLine(uniq[z] + " повторяется " + count + " раз ");
}

