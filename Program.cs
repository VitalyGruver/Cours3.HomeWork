// Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
/*

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
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

int[] Change(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    return array;
}

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение массива: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, minValue, maxValue);

ShowArray(myArray);
Console.WriteLine();
Change(myArray);
ShowArray(myArray);

*/


// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
/*

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
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

bool FindNumInArray(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
        if (array[i] == num) return true;
    return false;
}

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение массива: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите цифру для поиска в массиве: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, minValue, maxValue);

ShowArray(myArray);
Console.WriteLine(FindNumInArray(myArray, num));

*/

// Задайте массив из m случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [a,b].
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
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

int Colichestvo(int[] array, int a, int b)
{
    int num1 = 0;
    int num2 = 0;
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == a) num1 = a;
        if (array[i] == b) num2 = b;
    }
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= a && array[i] <= b) sum++;
    }
    return sum;
}

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение массива: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите начало диапазона: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конец диапазона: ");
int b = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, minValue, maxValue);
int sum = Colichestvo(myArray, a, b);
ShowArray(myArray);
Console.WriteLine(sum);

