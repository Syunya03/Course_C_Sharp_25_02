/*Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8 -> 30
*/

void SumNum(int M, int N, int sum)
{
    if (M > N)
    {
    Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}");
    return;
    }
    sum += M++;
    SumNum(M, N, sum);
}


Console.Write("Задайте значение M: ");
int numM = int.Parse(Console.ReadLine()!);
Console.Write("Задайте значение N: ");
int numN = int.Parse(Console.ReadLine()!);
SumNum(numM, numN, 0);