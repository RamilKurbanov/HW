// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Suma (int n)
{
    int sum = 0;
    while (n != 0)
    {
        sum = sum + n%10;
        n = n/10;
    }
    return sum;
}

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма введеных числел равна {Suma(number)} ");

