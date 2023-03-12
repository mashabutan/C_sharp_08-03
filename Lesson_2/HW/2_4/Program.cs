//Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число от 1 до 7: ");
int num = int.Parse(Console.ReadLine()!);

if (num > 7)
{
    Console.WriteLine("Это не день недели");
}

else if (num >=6 && num <= 7)
{
    Console.WriteLine("Это выходной");
}
if (num >=1 && num <= 5 )
{
    Console.WriteLine("Это будний день");
}




