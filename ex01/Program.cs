// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


int A_to_B (int A, int B)
{
    int result = 1;
    for (int i = 1; i <= B; i++)
    {
        result = result*A;
    }
    return result;
}

Console.Write("Введите число A: ");
int numb1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
int numb2 = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Результат возведения {numb1} в степень числа {numb2} равен {A_to_B(numb1, numb2)}");
