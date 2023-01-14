// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

void GetNums(int num1, int num2)
{
    Console.Write(num1 + " ");
    if (num1 > num2) GetNums(num1 - 1, num2);
    if (num2 > num1) GetNums(num1 + 1, num2);

}

Console.Write("Input m: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input n: ");
int num2 = Convert.ToInt32(Console.ReadLine());

GetNums(num1, num2);



// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B.
 
int Num (int a, int b)
{
    if (b > 0) return Num (a, b - 1) * a;
    return 1;
}

Console.Write("Input A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input B: ");
int b = Convert.ToInt32(Console.ReadLine());
int result = Num (a, b);
Console.Write(result);