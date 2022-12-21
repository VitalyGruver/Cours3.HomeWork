// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*
int Exponentiation (int num, int degree)
{
    int result = num;
    for (int i = 1; i < degree; i++)
    {
        result = result * num;
    }
    return result;
}

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень в которую необходимо возвести число: ");
int degree = Convert.ToInt32(Console.ReadLine());

int result = Exponentiation (num, degree);

Console.WriteLine($"{num} в степени {degree} - это {result}");
*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*

int FindSum(int num)
{
    int sum = num % 10;
    int current = num / 10;
    while (current > 0)
    {
        sum = sum + current % 10;
        current = current / 10;
    }
    return sum;
}

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int sum = FindSum(num);

Console.WriteLine($"Сумма цифр в числе равна {sum}");
/*

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

/*
int[] CreateRandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i+1} элемент массива: ");
        int num = Convert.ToInt32(Console.ReadLine());
        array[i] = num;
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

ShowArray(CreateRandomArray(size));
*/