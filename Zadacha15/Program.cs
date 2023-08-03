// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Определим, является ли выбранный день недели выходным днём.");
Console.WriteLine("Введите цифру дня недели от 1 до 7, где Пн-1, Вт-2 .. Вс-7 :");
string strNum = Console.ReadLine();
int num = int.Parse(strNum);

while (num <= 0 || num > 7)
{
    Console.WriteLine("Неверно выбран номер дня недели");
    Console.WriteLine("Определим, является ли выбранный день недели выходным днём.");
    Console.WriteLine("Введите цифру дня недели от 1 до 7, где Пн-1, Вт-2 .. Вс-7 :");
    strNum = Console.ReadLine();
    num = int.Parse(strNum);
}
if (num==6||num==7)
{
Console.WriteLine($"{num} -> да");
}
else 
{
Console.WriteLine($"{num} -> нет");
}