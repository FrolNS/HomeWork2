/*
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

int getSecondDigit(int number)
{
  int secondNumber = new int();
  secondNumber = number % 100 / 10;
  return secondNumber;
}

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int secondDigit = getSecondDigit(number);
Console.WriteLine($"Второе число от {number} - {secondDigit}");