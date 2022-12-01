int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result)
        result = arg2;
    if (arg3 > result)
        result = arg3;
    return result;
}

int[] array = {16, 22, 34, 43, 35, 6, 17, 38, 9, 34}
array[0] = 23;

int max1 = Max(array, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);

int max = Max(max1, max2, max3);

Console.WriteLine(max);
