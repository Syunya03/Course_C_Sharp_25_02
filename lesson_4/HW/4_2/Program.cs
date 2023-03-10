 /*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/


int Sum (int number)
{
      int result= 0;
    while (number>0)
    {
        result += number%10;
        number = number/10;
    }  
return result;
}

Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine()!);
int result = Sum(A);
Console.WriteLine(result);