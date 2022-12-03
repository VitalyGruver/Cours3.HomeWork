// 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*

int ShowSecondNum(int num)
{
    int result = num / 10 % 10;
    return result;
}

int randomNum = new Random().Next(100, 1000);

Console.WriteLine($"Вторая цифра числа {randomNum} - {ShowSecondNum(randomNum)}");

*/


// 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int ShowThirdNum(int num)
{
    int thirdNum = -1;
    if (num < 100)
    {
        return thirdNum;
    }
    else
    {
        if (num > 1000)
        {
            while (num > 1000)
            {
                num = num / 10;
            }
        }

        thirdNum = num % 10;

        return thirdNum;
    }
}

Console.WriteLine("Привет! Введи любое число больше 99 и я покажу тебе его третью цифру: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = ShowThirdNum(num);

if (result == -1)
    {
        Console.WriteLine("Ну я же просил больше 99 (");
    }
else
    {
        Console.WriteLine($"Третья цифра числа {num} - это {result}");
    }
