// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

int Sum (int num)
{
    int count = 0;
    for (int i = 1; i <= num; i++)
    {
        Console.Write($"Число {i}: ");
        int a = int.Parse(Console.ReadLine()!);
        if (a > 0) count ++;
    }
    return count;
}
Console.WriteLine("Сколько чисел хотите ввести?: ");
int a = int.Parse(Console.ReadLine()!);
int result = Sum(a);
Console.WriteLine($"Количество чисел больше 0: {result}");
