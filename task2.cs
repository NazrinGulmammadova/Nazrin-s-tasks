int[] arr = { 3, 6, 9 };
int largestNumber = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > largestNumber)
    {
        largestNumber = arr[i];
    }
}
Console.WriteLine(largestNumber);

