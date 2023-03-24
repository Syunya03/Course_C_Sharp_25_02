/*Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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

void Print_2(int[,] arr_2)
{
    int row = arr_2.GetLength(0);
    int column = arr_2.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            Console.Write($" {arr_2[i, j]} ");
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

void Result(int[,] arr, int[,] arr_2)
{
    int[,] result_arr = new int[arr.GetLength(0), arr_2.GetLength(1)];

    {
        if (arr.GetLength(0) != arr_2.GetLength(1))
        {
            Console.WriteLine(" Нельзя перемножить ");
            return;
        }
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr_2.GetLength(1); j++)
            {
                result_arr[i, j] = 0;
                for (int k = 0; k < arr.GetLength(1); k++)
                {
                    result_arr[i, j] += arr[i, k] * arr_2[k, j];
                }
                
                Console.WriteLine($" {result_arr[i,j]}");
               
            }
        }
    }
    
}


Console.Write("Введите количество строк 1го массива: ");
int num_row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов1го массива: ");
int num_column = int.Parse(Console.ReadLine()!);
Console.Write("Введите начало 1го массива: ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Введите окончание 1го массива: ");
int stop = int.Parse(Console.ReadLine()!);
Console.WriteLine();

Console.Write("Введите количество строк 2го массива: ");
int num_row_2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов 2го массива: ");
int num_column_2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите начало 2го массива: ");
int start_2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите окончание 2го массива: ");
int stop_2 = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(num_row, num_column, start, stop);
int[,] mass_2 = MassNums(num_row, num_column, start, stop);
Print(mass);
Print_2(mass_2);
Result(mass,mass_2);


