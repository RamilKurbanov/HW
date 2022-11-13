// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int FillArray(int[] mass)
{
    int length=mass.Length;
    for (int i = 0; i < length; i++ )
    {
        mass[i] = int.Parse(Console.ReadLine()!);
    }
    return length;
} 
int PrintArray(int[] col)
{
    int count = col.Length;
    for (int i = 0; i<count-1; i++)
    {
        Console.Write($"{col[i]},");
    }
    Console.Write($"{col[7]}");
    return count;
}

Console.WriteLine("Введите элементы массива: ");
int[] array = new int[0];
FillArray(array);
Console.Write("Массив: [");
PrintArray(array);
Console.Write("]");
