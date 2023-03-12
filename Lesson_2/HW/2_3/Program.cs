// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int result;
if (num < 100)

    {
        Console.WriteLine("Такой цифры нет");
    }

    while (num > 999)
    {
    {
        num = num / 10;
    }
    if (num >= 100 && num <=999)
    {
        result = num % 10;
        Console.WriteLine(result);
    }
    }
    

