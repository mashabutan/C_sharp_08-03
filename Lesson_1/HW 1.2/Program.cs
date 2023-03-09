// Напишите программу, которая принимает на вход три числа и 
//выдает максимальное из этих чисел 

Console.Write("Введите первое число: ");
int a = int.Parse (Console.ReadLine()!);
Console.Write("Введите второе число: ");
int b = int.Parse (Console.ReadLine()!);
Console.Write("Введите второе число: ");
int c = int.Parse (Console.ReadLine()!);


if (a > b)
{
    if (a > c)
    {
    Console.WriteLine("Максимальное первое число число");
    }
    else
    {
    Console.WriteLine("Максимальное третье число");
    
    }

}

{else if (b > c)
    Console.WriteLine("Максимальное второе число");
else 
    Console.WriteLine("Максимальное третье число");
}
