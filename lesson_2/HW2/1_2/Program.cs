/*Задача 1: Напишите программу, которая выводит случайное трёхзначное число 
и удаляет вторую цифру из этого числа
*/

int TakeNum(int num)
{
    Console.WriteLine(num);
    int resulut1 = num % 100;
    int resulut2 = num / 100;
    if (resulut1 > resulut2)
    {
        return resulut1;
    }
    else
    {
        return resulut2;
    }
}

int itog = TakeNum(new Random().Next(100, 1000));
Console.WriteLine(itog);
