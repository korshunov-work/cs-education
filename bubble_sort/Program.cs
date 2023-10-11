int[] array = { 6, 7, 9, 1, 2, 5, 3 };
int transfer;
bool check = true;
while (check == true)
{
    check = false;
    for (int i = 0; i < (array.Length - 1); i++)
    {
        if (array[i] > array[i + 1])
        {
            transfer = array[i];
            array[i] = array[i + 1];
            array[i + 1] = transfer;
            check = true;
        }
    }
}
foreach (int i in array)
{
    Console.Write(i + " ");
}