/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/



 
void PalindromNumber (int number)
{ 
    if (number >= 10000 && number < 100000)
    {
        int num1 = number / 10000;
        int num5 = number % 10;
               
               if (num1 == num5)
               
               {
               int num2 = (number / 1000)%10;
               int num4 = number / 10 % 10;
                   if(num2 == num4)
                    Console.WriteLine("Число является палиндромом");
               }
               else
               Console.WriteLine("Число не является палиндромом");
    }
    else 
     Console.WriteLine("Некорректное число");
}
Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine()!);
PalindromNumber(number);