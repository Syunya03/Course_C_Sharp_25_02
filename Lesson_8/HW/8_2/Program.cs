/*Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
наименьшей суммой элементов: 1 строка
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



int SumLine(int[,] arr, int i)
{
int sum = arr[i,0];

for (int j = 1; j < arr.GetLength(1); j++)

sum += arr[i,j];

return sum;
}
void SumLine_2(int [,]arr)
{
int minSum = 1;
int sum = SumLine(arr, 0);
for (int i = 1; i < arr.GetLength(0); i++)

if (sum > SumLine(arr, i))
{
sum = SumLine(arr, i);
minSum = i+1;
}

Console.WriteLine($"\nСтрока c наименьшей суммой элементов: {minSum}");
}
 Console.WriteLine("Введите количество строк массива");
int num_row = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество колонок массива");
int num_column = int.Parse(Console.ReadLine()!);
Console.WriteLine("Задайте минимальное число в массиве");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Задайте максмальное число в массиве");
int stop = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(num_row, num_column, start, stop);
Print(mass);
SumLine_2(mass);

