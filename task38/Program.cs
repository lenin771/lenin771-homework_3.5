// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Введите длину массива");
string number = Console.ReadLine()!;
int Size = int.Parse(number);
int[] array = CreateRandomArray(Size);
PrintArray(array);
Console.WriteLine($"\nМаксимальный элемент массива {arrayMaxElem(array)}, Минимальный элемент массива {arrayMinElem(array)}");
Console.WriteLine($"\nРазница между максимальным и минимальным элементами массива = {arrayMaxElem(array) - arrayMinElem(array)}");
// по логике из формулы a - b, где a = 8, b = -9, то 8 - (-9) = 17. 

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
        array[i] = new Random().Next(0, 100);  // правая граница не включается
    }
    return array;
}

static int arrayMaxElem(int[] array)
{
    int maxNum = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (maxNum < array[i])
        {
            maxNum = array[i];
        }
    }
    return maxNum;
}

static int arrayMinElem(int[] array)
{
    int minNum = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (minNum > array[i])
        {
            minNum = array[i];
        }
    }
    return minNum;
}
