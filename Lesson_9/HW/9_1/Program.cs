/*Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные
натуральные числа в промежутке от M до N с помощью рекурсии.

M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8"
*/

void SumNum(int M, int N)
{
    if (M > N)
        return;
    if (M % 2 == 0)
    {
        Console.Write($"{M}  ");
    }
    SumNum(M + 1, N);
}
Console.Write("Задайте значение M: ");
int numM = int.Parse(Console.ReadLine()!);
Console.Write("Задайте значение N: ");
int numN = int.Parse(Console.ReadLine()!);
SumNum(numM, numN);


