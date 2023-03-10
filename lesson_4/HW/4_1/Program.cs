/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/


int Degree(int num_A, int num_B)
{
  int res = 1;
  for(int i=1; i <= num_B; i++)
  {
    res = res * num_A;
  }
  
    return res;
}

  Console.Write("Введите число: ");
  int num_A = int.Parse(Console.ReadLine()!);
  Console.Write("Введите cтепень числа: ");
  int num_B = int.Parse(Console.ReadLine()!);

  int value = Degree(num_A, num_B);
  Console.WriteLine("Ответ: " + value);

