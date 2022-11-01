int[] arr = { -2, 4, 6, 8 };
int countPositive = 0;
int countNegative = 0;
for (int i=0; i<arr.Length; i++)
{
    if (arr[i] > 0)
    {
        countPositive++;
    }
    else if (arr[i] < 0)
    {
        countNegative++;
    }
}
Console.WriteLine(countPositive);
Console.WriteLine(countNegative); 