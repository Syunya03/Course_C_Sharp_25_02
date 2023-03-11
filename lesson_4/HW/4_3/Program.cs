/*Напишите программу, которая задает массив из 8 элементов случайными цифрами и выводит их на экран.
Оформите заполнение массива и вывод в виде функции
1, 2, 5, 7, 19, 1, 2, 8 -> 1, 2, 5, 7, 19, 1, 2, 8
6, 1, 33, 5, 6, 7, 7 ,1 -> 6, 1, 33, 5, 6, 7, 7 ,1 /
*/







int Prompt(string message);

int[] Massiv(int length, int min, int max)
{
    int[] array = new int[length];
    Random mas = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = mas.Next(10);
    }
    return array;
}

void Array(int[] array)
{
Console.Write("[");
for (int i = 0; i < array.Length- 1; i++)
{
    Console.Write($"{array[i]}, ");
}
 Console.Write($"{array[array.Length-1]} ");
 Console.Write("]");
}

int length = Prompt("Длина массива: ");
int min = Prompt("Минимальное значение массива: ");
int max = Prompt("максимальное значение массива: ");
int [] array = Massiv( length, min, max);
Array(array);