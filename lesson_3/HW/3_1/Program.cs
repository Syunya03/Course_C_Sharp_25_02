/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

double example (double x1, double y1, double z1, double x2, double y2, double z2)
{
return Math.Cbrt(Math.Pow(x2-x1, 3)+ Math.Pow(y2-y1, 3)+ Math.Pow(z2-z1, 3));
}
Console.WriteLine(example(3, 6, 8, 2, 1, -7));


double example2 (double x1, double y1, double z1, double x2, double y2, double z2)
{
return Math.Cbrt(Math.Pow(x2-x1, 3)+ Math.Pow(y2-y1, 3)+ Math.Pow(z2-z1, 3));
}
Console.WriteLine(example2(7, -5, 0, 1, -1, 9));




