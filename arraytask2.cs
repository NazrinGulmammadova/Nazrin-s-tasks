int[] arr = { 5, 10, 12, 14, 15, 9 };
int sum = 0;
int avarage = 0;
int num;
for (int index = 0; index < arr.Length; index++)
{
    if (num == arr[index])
    {
        sum = sum + num;
        avarage = sum / arr.Length;
    }


}
    Console.WriteLine(avarage);