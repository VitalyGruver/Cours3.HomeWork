int CutNumber(int num)
{
    int sot = num / 100;
    int ed = num % 10;

    int result = sot * 10 + ed;
    return result;
}

int randNum = new Random().Next(100, 1000);

int newNum = CutNumber(randNum);

Console.WriteLine($"New version of a number {randNum} is {newNum}.");

if(newNum > 0 && newNum % 2 == 0)