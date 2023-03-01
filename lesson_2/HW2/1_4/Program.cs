/*Напишите программу, которая принимает на вход цифру, обозначающую день недели,
 и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/



string s_a = Console.ReadLine()!;

if (s_a == "1")
{
    Console.WriteLine("<Будний день>");
}
else if (s_a == "2")
{
    Console.WriteLine("Будний день");
}

else if (s_a == "3")
{
    Console.WriteLine("Будний день");
}

else if (s_a == "4")
{
    Console.WriteLine("Будний день");
}

else if (s_a == "5")
{
    Console.WriteLine("Будний день");
}

else if (s_a == "6")
{
    Console.WriteLine("Выходной");
}

else if (s_a == "7")
{
    Console.WriteLine("Выходной");
}

else
{
    Console.WriteLine("Не день недели");
}