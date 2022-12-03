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

/*

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

*/

// 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*

bool CheckDayOff(int dayNum)
{
    if (dayNum == 6 || dayNum == 7)
        return true;
    else
        return false;
}

int day = new Random().Next(1, 8);

bool dayOff = CheckDayOff(day);

if (dayOff == true)
{
    Console.WriteLine($"{day} день недели - это выходной!");
}
else
    Console.WriteLine($"{day} день недели - это не выходной!");

*/