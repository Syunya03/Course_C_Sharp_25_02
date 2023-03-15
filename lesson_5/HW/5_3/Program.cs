/*Задайте массив вещественных чисел. Найдите разницу между максимальным и
 минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

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

void Minus(double[] arr)
{
    double min = arr[0];
    double max = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (max < arr[i])
        {
            max = arr[i];
        }
        else if (min > arr[i])
        {
            min = arr[i];
        }
    
        
    }


    
    Console.WriteLine($"Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {max - min}");
}


Console.Write("Введите количество элементов массива: ");
int num = int.Parse(Console.ReadLine()!);
Console.Write("Введите начало массива: ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Введите окончание массива: ");
int stop = int.Parse(Console.ReadLine()!);

Double[] mass = MassNums(num, start, stop);
Print(mass);
Minus(mass);


