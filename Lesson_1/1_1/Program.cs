// напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом    второго. (a = 25, b = 5 -> да; a = 2, b = 10 -> нет; a = 9, b = -3 -> да; a = -3, b = 9 -> нет)

string s_a = Console.ReadLine()!;
string s_b = Console.ReadLine()!;
int a = int.Parse(s_a);
int b = int.Parse(s_b);

if (a == b * b) Console.WriteLine("Yes");
else Console.WriteLine("No");