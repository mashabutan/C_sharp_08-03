// Задайте массив заполненный случайными числами. Напишите программу, которая покажет 
//количество четных чисел в массиве.

Console.Write("Кол-во элементов:");
int count =int.Parse(Console.ReadLine()!);
Console.Write("Начало диапозона:");
int a =int.Parse(Console.ReadLine()!);
Console.Write("Конец диапозона:");
int b =int.Parse(Console.ReadLine()!);

int[] MakeArray(int c, int m, int n){
int[] array =new int[c];

for (int i=0;i<array.Length;i++) array[i]=new Random().Next(m,n+1);
return array;
}
void PrintArray(int[] arr){
for (int i=0;i<arr.Length;i++) Console.Write($"{arr[i]} ");
Console.WriteLine();
}

int[] array=MakeArray(count, a,b);
PrintArray(array);
////////////////////////////////////////////

int numbers = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i]%2 == 0)
    numbers++;
}
Console.WriteLine($"всего {array.Length} чисел, из них  {numbers} положительных");
