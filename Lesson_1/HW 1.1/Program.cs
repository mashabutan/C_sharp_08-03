// Напишите программу, которая на вход принимает два числа и выдает, 
//какое число больше, а какое меньше

Console.Write("Введите первое число: ");
int a = int.Parse (Console.ReadLine()!);
Console.Write("Введите второе число: ");
int b = int.Parse (Console.ReadLine()!);

 if (a > b)
 {
    Console.WriteLine("Большее число первое, меньшее число второе");
 }
 else 
 {
    Console.WriteLine("Большее число второе, меньшее число первое");
 }   
