// Напишите цикл, который принимает на вход два числа (A и B) и возводит число А в степень В
// 3, 5 -> 243 2, 4 -> 16
Console.WriteLine ("Введите число А ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine ("Введите число B ");
int b = int.Parse(Console.ReadLine()!);
int degree = a;
for (int i = 1; i <= b; i++)
{
    degree = degree * a;
   
}
    
Console.WriteLine(" А в степени В равно: " + degree);