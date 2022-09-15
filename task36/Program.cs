// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях

Console.WriteLine("Введите длину массива");
string number = Console.ReadLine()!;
int Size = int.Parse(number);
int[] array = CreateRandomArray(Size);
PrintArray(array);
int positivesSum = CalcPositivesSum(array);
Console.WriteLine($"\nСумма элементов на нечетных позициях = {positivesSum}");

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
        array[i] = new Random().Next(10, 100);  // правая граница не включается
    }
    return array;
}

static int CalcPositivesSum(int[] array)
{
    int positivesSum = 0;

    for (int i = 1; i <= array.Length; i = i + 2)
    {
        positivesSum += array[i];
    }
    return positivesSum;
}

