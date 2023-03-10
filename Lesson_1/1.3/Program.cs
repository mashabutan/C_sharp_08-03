Console.WriteLine("N=");
int n = int.Parse(Console.ReadLine()!);


int count = -n;

while (count != n)
{
    Console.writeLine(count);
    if (n < 0)
    {
        count--;
    }
    count++;


    else
    {
        count++;
    }
}