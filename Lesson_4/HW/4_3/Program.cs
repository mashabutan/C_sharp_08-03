// Напишите программу, которая задает массив и выводит его на экран
void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.WriteLine($"{arr[i]} ");
    Console.WriteLine();

}
int[] Array(int size, int start, int stop)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(start, stop +1);
    return arr;
}
int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);
int[] mass = Array(num, start, stop);
Print(mass);