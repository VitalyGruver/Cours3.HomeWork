// 1. Напишите программу, которая принимает на вход число и проверяет, является ли оно палиндромом.
/*

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

*/

// 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*

double FindDistance( double xA, double yA, double zA, double xB, double yB, double zB)
{
    double distance = Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2) + Math.Pow(zA - zB, 2));
    return distance;
}

Console.WriteLine("Input first x: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input first y: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input first z: ");
double zA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input second x: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input second y: ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input second z: ");
double zB = Convert.ToDouble(Console.ReadLine());

double dist = Math.Round(FindDistance(xA, yA, zA, xB, yB, zB),3);

Console.WriteLine($"Distance = {dist}");

*/

// 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*


void CubeTable (int n)
{
    int index = 1;
    while (index <= n)
    {
        Console.Write(Math.Pow(index,3) + " ");
        index = index + 1;
    }
}

Console.WriteLine("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());

CubeTable (n);

*/
