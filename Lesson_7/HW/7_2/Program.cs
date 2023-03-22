/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
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
void Print_2(int[,] arr, int row, int column)
{
   if (row < 0 & row > arr.GetLength(0) - 1 & column < 0 & 
        column > arr.GetLength(1) - 1)
        Console.WriteLine("такого элемента нет");
    else
        Console.WriteLine($" {arr[row-1, column-1]} ");
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
Console.Write("Введите строку: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите столбец: ");
int column = int.Parse(Console.ReadLine()!);
Print_2(mass,row,column);











