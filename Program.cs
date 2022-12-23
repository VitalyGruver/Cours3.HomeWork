// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*

int[] CreateRandomArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }

    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();

}

int NumEven(int[] array)
{
    int result = 0;
    int even = 0;
    for (int i = 0; i < array.Length; i++)
    {
        even = array[i] % 2;
        if (even == 0) result++;
    }
    return result;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size);

Console.WriteLine();
ShowArray(myArray);
Console.WriteLine();
Console.WriteLine($"В массиве {NumEven(myArray)} четных чисел");

*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

/*
int[] CreateRandomArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 100);
    }

    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();

}

int FindSum(int[] array)
{
    int sum = 0;
    int noEven = 0;
    for (int i = 0; i < array.Length; i++)
    {
        noEven = i % 2;
        if (noEven != 0) sum += array[i];
    }
    return sum;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size);

Console.WriteLine();
ShowArray(myArray);
Console.WriteLine();
Console.WriteLine($"Сумма элементов стоящих на нечетных позициях - {FindSum(myArray)}");

*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

/*

[3 7 22 2 78] -> 76

*/