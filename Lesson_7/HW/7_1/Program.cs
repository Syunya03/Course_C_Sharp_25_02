/*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9     */


void Print(double[,] arr)
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

double [,] MassNums(int row, int column, int from, int to)
{
double[,] arr = new double[row, column];
Random n_new = new Random();
for (int i = 0; i < row; i++)
for (int j = 0; j < column; j++)
arr[i, j] = n_new.NextDouble() * (from + to) - to;

return arr;
}

Console.Write("Введите количество строк: ");
int num_row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int num_column = int.Parse(Console.ReadLine()!);
Console.Write("Введите начало массива: ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Введите окончание массива: ");
int stop = int.Parse(Console.ReadLine()!);

double[,] mass = MassNums(num_row, num_column, start, stop);
Print(mass);