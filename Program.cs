// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.



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
void MatrixMultiplex(int[,] array1, int[,] array2)
{
    if (array1.GetLength(1) == array2.GetLength(0)) // Проверяем возможность перемножения матриц
    {
        int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];  // Создаем результирующий массив
        for (int i = 0; i <= array1.GetLength(0) - 1; i++) // Двигаемся по столбцам первой матрицы
        {
            for (int j = 0; j < array1.GetLength(1) - 1; j++) // Двигаемся по строкам первой матрицы
            {
                for (int h = 0; h < array1.GetLength(1); h++) // Умножаем элементы и записываем сумму в результирующую матрицу
                {
                    array3[i, j] += array1[i, h] * array2[h, j];
                }
            }
        }


        for (int i = 0; i < array3.GetLength(0); i++) // Выводим результирующую матрицу
        {
            for (int j = 0; j < array3.GetLength(1); j++)
            {
                Console.Write(array3[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    else
        Console.WriteLine("Перемножение матриц невозможно!");
}

int[,] array1 = CreateRandom2dArray();
Show2dArray(array1);
Console.WriteLine();
int[,] array2 = CreateRandom2dArray();
Show2dArray(array2);
MatrixMultiplex(array1, array2);

*/

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

/*
int[,,] CreateRandom3dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of layers: ");
    int layers = Convert.ToInt32(Console.ReadLine());
    int[,,] array = new int[rows, columns, layers];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            for (int z = 0; z < layers; z++)
            {
                array[i, j, z] = new Random().Next(10, 99); // Генерируем элемент массива
                for (int x = 0; x < rows; x++) // Сравниваем сгенерированный элемент со всеми другими
                    for (int y = 0; y < columns; y++)
                        for (int k = 0; k < layers; k++)
                        {
                            if (array[i, j, z] == array[x, y, k]) // Если элемент уже есть, генерируем новый
                                array[i, j, z] = new Random().Next(10, 99);
                        }
            }
    return array;
}

void Show3dArray(int[,,] array)
{
    for (int z = 0; z < array.GetLength(2); z++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int i = 0; i < array.GetLength(0); i++)
                Console.Write($"{array[i, j, z]} ({i}, {j}, {z}) \t");
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[,,] myArray = CreateRandom3dArray();
if (myArray.GetLength(0) * myArray.GetLength(1) * myArray.GetLength(2) < 89)
    Show3dArray(myArray);
else
    Console.WriteLine(
        "Невозможно создать массив из неповторяющихся двухзначных чисел такого размера"
    );

*/

// Задача 62. (Решил не до конца, не хватило времени. Оставил для себя, чтобы закончить) Напишите программу, которая заполнит спирально массив 4 на 4.

/*

int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    int i = 0;
    int j = 0;

    for (int k = 1; k < rows * columns; k++)
    {
        while (j < columns - k) // Двигаемся вправо
        {
            array[i, j + 1] = array[i, j] + 1;
            j++;
        }
        while (i < rows - k) // Двигаемся вниз
        {
            array[i + 1, j] = array[i, j] + 1;
            i++;
        }
        while (j >= k) // Двигаемся влево
        {
            array[i, j - 1] = array[i, j] + 1;
            j--;
        }
        while (i > k) // Двигаемся вверх до k
        {
            array[i - 1, j] = array[i, j] + 1;
            i--;
        }
    }

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

int[,] myArray = CreateRandom2dArray();
Console.WriteLine();
Show2dArray(myArray);

*/