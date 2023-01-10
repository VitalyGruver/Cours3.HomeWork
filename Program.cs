// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

/*

int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void SortRowsDescending(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)  // Двигаемся по вертикали до последней строки
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++) // Двигаемся по горизонтали до предпоследнего элемента строки
        {
            for (int h = j+1; h < array.GetLength(1); h++) // Сравниваем элементы с первым и меняем местами, если больше первого
            {
                if (array[i, j] < array[i, h])
                {
                    int temp = array[i, j];
                    array [i, j] = array[i, h];
                    array [i, h] = temp;
                }
            }
        }
    }
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Console.WriteLine();
SortRowsDescending(myArray);
Show2dArray(myArray);

*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальное значение: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное значение: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FindStringWithMinSum (int[,] array)
{
    int[] sum = new int[array.GetLength(0)];
    Console.Write("Суммы элементов строк: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {   

        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum[i] += array[i,j];
        }
        Console.Write(sum[i] + " ");
    }
    Console.WriteLine();
    Console.WriteLine();

    int indexMin = 0;
    for (int i = 0; i < sum.Length; i++)
    {
        if (sum[i] < sum[indexMin]) indexMin = i;
    }
    Console.WriteLine($"Строка {indexMin+1} имеет наименьшую сумму элементов");
}

int[,] myArray = CreateRandom2dArray();
Console.WriteLine();
Show2dArray(myArray);
Console.WriteLine();
FindStringWithMinSum (myArray);



*/

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

/*  result [i,j] = array1 [i,j] * array2 [i,j] + array1[i+1,j] * array2 [i,j+1];

*/

int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void MatrixMultiplex (int[,] array1, int[,] array2)
{
    if (array1.GetLength(1) == array2.GetLength(0))
    {
        int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                array3[i,j] = array1[i,j] * array2[i,j];
            }
        }           
    }
    else Console.WriteLine("Перемножение матриц невозможно!");

}

int[,] array1 = CreateRandom2dArray();
Show2dArray(array1);
Console.WriteLine();
int[,] array2 = CreateRandom2dArray();
Show2dArray(array2);
MatrixMultiplex (array1, array2);
/*
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18

Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)

*/

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

/*
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07

*/