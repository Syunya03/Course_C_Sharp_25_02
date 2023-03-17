//Напишите программу, которая будет создавать копию заданного массива с помощью
//поэлементарного копирования.

void Print(double[] arr)
{
int size = arr.Length;

for (int i = 0; i < size; i++)
Console.Write($"{arr[i]} ");
Console.WriteLine();
}

double[] MassNums(int size, int from, int to)
{
double[] arr = new double[size];
Random n_new = new Random();

for (int i = 0; i < size; i++)
arr[i] = n_new.NextDouble() * (from + to) - to;
return arr;
}

void Copy(double[] arr)

{ double[] new_arr = new double[arr.Length];
int size = new_arr.Length;
for (int i = 0; i < size; i++)
new_arr[i] = arr[i];

Console.WriteLine($"Копия заданного массива = {new_arr}");
}

Console.Write("Введите количество элементов массива: ");
int num = int.Parse(Console.ReadLine()!);
Console.Write("Введите начало массива: ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Введите окончание массива: ");
int stop = int.Parse(Console.ReadLine()!);

double[] mass = MassNums(num, start, stop);
Print(mass);
Copy(mass);
Print(mass);


