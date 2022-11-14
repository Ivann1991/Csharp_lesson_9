//  Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
Console.Write("Введи целое число N: ");
int usernum = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine (PrintNaturals(usernum, 1));
string PrintNaturals(int start, int end)
{
    if (start == end)
    {
        return start.ToString();
    }
return (start + ", " + PrintNaturals (start - 1, end));
}
