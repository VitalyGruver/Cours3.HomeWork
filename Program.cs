// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*

Console.Write("Input first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
    {
        Console.WriteLine("max = " + number1);
    }
else 
    {
        Console.WriteLine("max = " + number2);
    }

*/

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if(max < num2)
    {
        max = num2;
    }
if(max < num3)
    {
        max = num3;
    }

Console.Write("Максимальное значение " + max);

*/

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите любую цифру: ");
int num = Convert.ToInt32(Console.ReadLine());

int num2 = num % 2;

if( num2 > 0)
    {
        Console.WriteLine($"Число {num} - нечетное");
    }
else
    {
        Console.WriteLine($"Число {num} - четное");
    }

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*

5 -> 2, 4
8 -> 2, 4, 6, 8

*/
