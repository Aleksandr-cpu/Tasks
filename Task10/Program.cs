// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


int SecondDigit(int num)
{
    int numResult = num / 10 % 10;
    return numResult;
}

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int secondDigit = SecondDigit(number);
Console.WriteLine($"{number} -> {secondDigit}");