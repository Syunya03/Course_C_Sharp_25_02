﻿/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
 стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to);
    return arr;
}

void Sum(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i += 2)
    {
        sum = sum + arr[i];
    }

    Console.WriteLine($"Сумма элементов,стоящих на нечётных позициях: {sum}");
}


Console.Write("Введите количество элементов массива: ");
int num = int.Parse(Console.ReadLine()!);
Console.Write("Введите начало массива: ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Введите окончание массива: ");
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
Print(mass);
Sum(mass);
