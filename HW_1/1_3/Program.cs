/* Задача 6:
Напишите программу, которая на вход принимает число и выдает, является ли число чётным
4 -> да, -3 -> нет, 7 -> нет.
*/

int a = int.Parse(Console.ReadLine()!);

if (a % 2 == 0) Console.WriteLine("Yes");
else Console.WriteLine("No");