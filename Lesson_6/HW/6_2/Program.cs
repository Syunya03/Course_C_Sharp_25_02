/*Пользователь вводит с клавиатуры n чисел. Посчитайте, сколько чисел больше 0 
ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/


Console.Write("Введите количество элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] arr = new int[n];

void Mass(int n)
{
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива ");
        arr[i] = int.Parse(Console.ReadLine()!);
    }
}

int Sum(int[] arr)
{

    int sum = 0;
    for (int i = 0; i < arr[i]; i++)
        sum = sum + 1;
    return sum;
}

Mass(n);
Console.Write($"Чисел больше 0: {Sum(arr)}");



