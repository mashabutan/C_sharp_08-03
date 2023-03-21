// Напишите программу, которая на вход приимает число и выдает сумму  цифр в числе

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int sum = 0;
while (number > 0)
{
int n = number % 10;
number = number / 10;
sum = sum + number;
}
 Console.WriteLine("Суммы всх цифр равна: " + sum);



