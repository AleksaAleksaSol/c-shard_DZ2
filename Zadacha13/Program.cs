// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет. Не использовать массив
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.WriteLine("Введите число для поиска его третьей цифры: ");
string strNum = Console.ReadLine();
int num = int.Parse(strNum);
int dig=0;

if (num > 99)
{
    for (int i = 1; i < num; i *= 10) //ищем какого порядка число
    {
        dig=i/10;
        //Console.WriteLine($"число dig= {dig}"); 
    }
    int num2 = dig/10; 
    int num4 = ((num % dig) - (num % num2)) / num2;
    Console.WriteLine($"Третья цифра заданного числа {num4}");
}
else Console.WriteLine($"Третей цифры в числе {num} нет, попробуй еще раз!");