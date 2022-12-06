/*

int FindQuadrant(double x, double y)
    {
    if(x>0 && y>0) return 1;
    if(x<0 && y>0) return 2;
    if(x<0 && y< 0) return 3;
    if(x>0 && y<0) return 4;
    return 0;
    };

Console.WriteLine("Input x: ");
double xA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input y: ");
double xA = Convert.ToDouble(Console.ReadLine());

int quadNum = FindQuadrant(xa,ya);

Console.WriteLine($"Point = {quadNum}");

*/


// 1. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

/*

void Range (int quart)
    {
        if (quart == 1)
        Console.Write("x(0 ... +∞), y(0 ... +∞)");

        if (quart == 2)
        Console.Write("x(-∞ ... 0), y(0 ... +∞)");

        if (quart == 3)
        Console.Write("x(-∞ ... -0), y(-∞ ... 0)");

        if (quart == 4)
        Console.Write("x(0 ... +∞), y(-∞ ... 0)");

        if (quart < 1 || quart > 4)
        Console.Write("Incorrect quarter");
        
    }

Console.WriteLine("Input quarter: ");
int quart = Convert.ToInt32(Console.ReadLine());

Range(quart);

*/

// 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
/*

double FindDistance(double xA, double yA, double xB, double yB)
{
    double distance = Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2));
    return distance;
}

Console.WriteLine("Input first x: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input first y: ");
double yA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input second x: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input second y: ");
double yB = Convert.ToDouble(Console.ReadLine());

double dist = Math.Round(FindDistance(xA, yA, xB, yB),3);

Console.WriteLine($"Distance = {dist}");

*/


// 3. Напишите программу, которая принимает на вход число (N) и выдаёт ряд квадратов чисел от 1 до N.

void RowSquares(int N)
{
    int result = 1;

    while (result <= N)
    {
        Console.Write(Math.Pow(result, 2) + " ");
        result++;
    }
}
Console.WriteLine($"Input N: ");
int N = Convert.ToInt32(Console.ReadLine());

RowSquares(N);


