// HomeWork 1

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


Console.WriteLine("Привет! Я помогу Вам узнать какая цифра из двух больше!\n");

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Отлично! Дайте мне вторую цифру: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int random = new Random().Next(0, 5);

string[] phrase = { " определенно", " точно", " сто процентов", " по-любому", " зуб даю" };

if (number1 > number2)
{
    Console.WriteLine("");
    Console.WriteLine("Цифра " + number1 + phrase[random] + " больше, чем " + number2);
}
else
{
    Console.WriteLine("");
    Console.WriteLine("Цифра " + number2 + phrase[random] + " больше, чем " + number1);
}



// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*

Console.WriteLine("Теперь задача по-сложнее. Дайте мне три цифры, и я скажу, какая из них больше! \n");

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
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

Console.WriteLine(" ");
Console.WriteLine("Число " + max + " здесь точно самое большое!");

*/

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*

Console.WriteLine("Теперь давайте узнаем какое число чётное, а какое нечётное!\n");
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

*/

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*

Console.WriteLine("Это всё были цветочки! Сейчас, если Вы дадите мне цифру, я выведу на экран все четные числа от 1 до Вашей цифры. \n");
Console.Write("Введите любое число: ");
int N = Convert.ToInt32(Console.ReadLine());

int current = 1;

int divCurrent = 1;

Console.WriteLine("");
Console.WriteLine("Вуаля!\n");


while (current < N)
    {
        divCurrent = current % 2;

        if (divCurrent > 0)

            {
                 Console.Write(current + 1 + " ");

            }
        

        current++;

    }

*/
