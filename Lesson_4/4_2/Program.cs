// Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
int num = GetNumber();
int digits = CountNumbers(num);
Console.WriteLine(digits);

int GetNumber()
{
int number = 0;
while(number == 0)
{
Console.Write("Please enter number: ");
number = int.Parse(Console.ReadLine()!);
}
return number;
}

int CountNumbers(int n)
{
int count = 0;
while (n > 0)
{
n = n/10;
count++;
}
return count;
}

