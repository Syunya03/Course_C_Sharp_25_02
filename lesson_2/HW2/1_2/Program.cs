/*Задача : Напишите программу, которая выводит случайное трёхзначное число 
и удаляет вторую цифру из этого числа
*/

string Num(int num)
{
    if (num < 1000 && num > 99)
        return $"{ num} {num / 100 * 10 + num % 10}";
    return "Номер без 2ой цифры";
}

Console.WriteLine(Num(int.Parse(Console.ReadLine()!)));

void NumRendom()
{
    int num = new Random().Next(100, 1000);
    Console.WriteLine($"{num}{num/100}{num%10}");
}

NumRendom();