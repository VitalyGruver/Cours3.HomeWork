// 1. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

/*
int Max(int maxNum)
{
    int num1 = maxNum / 10;
    int num2 = maxNum % 10;
    if (num1>num2)
        return num1;
    return num2;
}

int randomNum = new Random().Next(10, 100);

Console.WriteLine($"Случайное число - {randomNum}. Максимальная цифра - {Max(randomNum)}");

*/


// 2. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.

/*

bool Div(int a, int b)

{
    if (a % b == 0)
        return true;
    return false;
}

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool result = Div(num1, num2);

Console.WriteLine(result);

*/


// 3. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно a и b.

/*

bool Div(int a, int b, int c)

{
    if (a % b == 0)
        if (a % c == 0)
            return true;
    return false;
}


Console.WriteLine("Введите число для проверки: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите первый делитель: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второй делитель: ");
int num3 = Convert.ToInt32(Console.ReadLine());

bool result = Div(num1, num2, num3);

Console.WriteLine(result);

*/