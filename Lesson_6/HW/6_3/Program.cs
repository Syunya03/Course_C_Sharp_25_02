/*Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

void Straight_line(double b1, double k1,double b2, double k2)
{if(b1==b2 && k1==k2)
Console.WriteLine("Прямые совпадают");
else if (k1==k2)
Console.WriteLine("Прямые параллельны");
else
   {double line_X =(b2-b1)/(k1-k2);
     double line_Y= (k1*(b2-b1))/(k1-k2)+b1;
     Console.WriteLine($"line_X= {line_X}");
     Console.Write($"line_Y= {line_Y}");
   }
return;
}
Console.WriteLine("Введите b1: ");
double b1= double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите k1:");
double k1= double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите b2:");
double b2= double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите k2:");
double k2= double.Parse(Console.ReadLine()!);
Straight_line(b1,k1,b2,k2);


