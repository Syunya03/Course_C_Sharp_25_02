/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов
 в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

void Print(int[,] arr)
{
int row = arr.GetLength(0);
int column = arr.GetLength(1);

for (int i = 0; i < row; i++)
{
for (int j = 0; j < column; j++)
Console.Write($" {arr[i, j]} ");
Console.WriteLine();
}
Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
int[,] arr = new int[row, column];

for (int i = 0; i < row; i++)
for (int j = 0; j < column; j++)
arr[i, j] = new Random().Next(from, to);

return arr;
}

void Sum (int[,] arr)
{
for (int j = 0; j < arr.GetLength(1); j++)
{
   double sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum += arr[i, j];
    }
    Console.Write($"{Math.Round(sum / arr.GetLength(0),2)} ");
}
}

Console.Write("Введите количество строк: ");
int num_row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int num_column = int.Parse(Console.ReadLine()!);
Console.Write("Введите начало массива: ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Введите окончание массива: ");
int stop = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(num_row, num_column, start, stop);
Print(mass);
Sum(mass);
