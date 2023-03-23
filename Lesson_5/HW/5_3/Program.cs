// Задайте массив вещественных чисел. Найдите разицу между макс и мин элементов массива

// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечетных позициях.

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

double max = array[0];
double min = array[0];
for (int i=0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    else if (array[i]< min)
    {
         min = array[i];
    }
}
Console.Write($" min {min} ");
Console.Write($"max {max} ");
Console.Write($" diff {max - min} ");
