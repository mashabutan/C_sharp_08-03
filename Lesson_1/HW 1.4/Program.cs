// Напишите программу , которая на вход принимает число N, 
//а на выходе показывает все четные числа от 1 до N

Console.Write("Введите число: ");
int N = int.Parse (Console.ReadLine()!);

for (int i = 2; i <= N; i ++)
{
    if (i%2 == 0)
    Console.WriteLine(i);
}

