// 1. Напишите программу, которая принимает на вход число и проверяет, является ли оно палиндромом.

void checkPolindrom(int num)
{
    int FindNumOfDigits(int num)    //  Определяем сколько разрядов у числа
    {
        int divider = 1;
        int quotient = num / divider;
        int result = 1;

        while (quotient > 9)
        {
            divider = divider * 10;
            quotient = num / divider;
            result++;
        }
        return result;
    }

    int step = FindNumOfDigits(num) - 1;
    int numOnTheLeft = 0;
    int numOnTheRight = 0;

    while (num > 9 && numOnTheLeft == numOnTheRight)    //  Сравниваем крайние цифры, если равны - отбрасываем их и повторяем
    {
        numOnTheLeft = num / Convert.ToInt32(Math.Pow(10, step));
        numOnTheRight = num % 10;

        num = num % Convert.ToInt32(Math.Pow(10, step)) / 10;

        step = step - 2;

//      Console.WriteLine($"Index = {step} NumberOnTheLeft = {numOnTheLeft} NumberOnTheRight = {numOnTheRight} num = {num}");   // проверка вычислений цикла
    }

    if (numOnTheLeft == numOnTheRight) Console.WriteLine("Число является палиндромом!");
    else Console.WriteLine("Число не является палиндромом!");

}

Console.WriteLine("Введите число для проверки: ");
int num = Convert.ToInt32(Console.ReadLine());

checkPolindrom(num);


// 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53

Задача 23

// 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125

*/