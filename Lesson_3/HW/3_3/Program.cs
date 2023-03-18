// Напишите программу, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N.

void Pow(int num)
{
    int i = 1;
    while (i <= num)
    {
        Console.WriteLine(Math.Pow(i,3));
        i++;
    }
}
int number = int.Parse(Console.ReadLine()!);
Pow(number);