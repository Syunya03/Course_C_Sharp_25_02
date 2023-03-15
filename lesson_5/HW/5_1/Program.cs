/*Задайте массив заполненный случайными положительными трёхзначными числами. Напишите 
программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/





int n = int.Parse(Console.ReadLine()!);
int[] randArr = new int[n];

void mas(int n)
{
for (int i = 0; i < n; i++)
{
randArr[i] = new Random().Next(100,1000);
Console.Write(randArr[i] + " ");
}

}

int kol(int[] randArr)
{
int kol = 0;
for (int i = 0; i < randArr.Length; i++)
{
if (randArr[i] % 2 == 0)
kol = kol + 1;
}
return kol;
}

mas(n);
Console.WriteLine($"Количество чётных чисел в массиве: {kol(randArr)}");