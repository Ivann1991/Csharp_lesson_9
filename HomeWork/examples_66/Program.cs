﻿// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.Write("Введи целое число M: ");
int usernum1 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введи целое число N: ");
int usernum2 = int.Parse(Console.ReadLine() ?? "");
if (usernum1 < usernum2)
{
    Console.WriteLine($"сумма натуральных чисел от {usernum1} до {usernum2} равна {PrintNaturals(usernum1, usernum2)}");
}
else Console.WriteLine("вывод невозможен");
int PrintNaturals(int start, int end)
{
    if (start == end)
    {
        return start;
    }
    return (start + PrintNaturals(start + 1, end));
}

