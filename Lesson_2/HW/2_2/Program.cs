// Напишите программу , которая выводит  случайное трехзначное числои удаляет вторую цифру этого числа


int number = new Random(). Next (100, 1000);

 Console.WriteLine(number);

int FirstNum = number / 100;
int LastNum = number % 10;
int result = FirstNum * 10 + LastNum;

Console.WriteLine(result);