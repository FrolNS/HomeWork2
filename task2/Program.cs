/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

void weekend(int dayOfTheWeek)
{
    if (dayOfTheWeek == 6 || dayOfTheWeek == 7) Console.WriteLine("Да");
    else Console.WriteLine("Нет");  
}

Console.Write("Введите цифру, обозначающую день недели: ");
int dayOfTheWeek = Convert.ToInt32(Console.ReadLine());
weekend(dayOfTheWeek);