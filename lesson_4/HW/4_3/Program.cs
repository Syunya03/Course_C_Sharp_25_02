/*Напишите программу, которая задает массив из 8 элементов случайными цифрами и выводит их на экран.
Оформите заполнение массива и вывод в виде функции

*/


int[] Massive(int size, int from, int to)
{
int[] arr = new int[size];

for (int i = 0; i < size; i++)
{
arr[i] = new Random().Next(from, to);
}
return arr;

}

void Print(int[] arr)
{
int size = arr.Length;
for (int i = 0; i < size; i++)
Console.Write($"{arr[i]} ");
}

int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);
int[] mass = Massive(num, start, stop);
Print(mass);
