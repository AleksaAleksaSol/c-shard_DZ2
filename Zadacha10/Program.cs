// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
string strNum = Console.ReadLine();
int num = int.Parse(strNum);

while (num < 100 || num > 999)
{
    Console.WriteLine("Число не трехзначное");
    Console.WriteLine("Введите трехзначное число: ");
    strNum = Console.ReadLine();
    num = int.Parse(strNum);

}

num = ((num % 100) - (num % 10)) / 10;
Console.WriteLine($"Вторе число в данном трехзначном числе {num}");