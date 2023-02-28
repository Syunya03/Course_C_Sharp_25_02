/* Задача 2:
 Напините программу, которая на вход принимае два числа и выдает какое число больше, а какое меньше
 a = 5, b = 7 -> max = 7; a = 2, b = 10 -> max = 10, a = -9, b = -3 -> max = -3. 
 */

 int a = int.Parse(Console.ReadLine()!);
 int b = int.Parse(Console.ReadLine()!);
 
 if (a > b)
 {
    Console.WriteLine (a +"-max");
 }
 else if (a < b)
 {
    Console.WriteLine (b + "-max");
 }
 else
 {
    Console.WriteLine (" Error");
 }