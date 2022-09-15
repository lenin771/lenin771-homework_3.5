// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("Введите длину массива");
string number = Console.ReadLine()!;
int Size = int.Parse(number);
int[] array = CreateRandomArray(Size);
PrintArray(array);
int positivesSum = CalcPositivesSum(array);
Console.WriteLine($"\nКоличество четных чисел = {positivesSum}");

static void PrintArray(int[] array)
{
    foreach (int arr in array)
        Console.Write($"{arr} ");
}

static int[] CreateRandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);  // правая граница не включается
    }
    return array;
}

static int CalcPositivesSum(int[] array)
{
    int positivesSum = 0;

    foreach (int arr in array) 
    {
        if (arr % 2 == 0)
            positivesSum++;
    }
    return positivesSum;
}
