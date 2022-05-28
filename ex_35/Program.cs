// Задайте одномерный массив из 123 случайных чисел
// найти количество элементов массива, значения
// которых лежат в отрезке [10, 99]

int [] nums = new int [12];
var numRnd = new Random();
for (int i = 0; i < nums.Length; i++)
{
    nums [i] = numRnd.Next(0, 500);
    Console.Write(nums[i] + " ");
}
Console.WriteLine();
int j = 0;
for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] >= 10 && nums[i] < 100)
    {
        j++;
    }
}
Console.WriteLine();
Console.Write($"Количество элементов массива в отрезке {j}");
Console.WriteLine();

