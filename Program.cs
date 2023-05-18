int count = 0;
int count1 = 0;
int count2 = 0;
int max = Int32.MinValue;
int min = Int32.MaxValue;
for (int i = 1; i <= 10; i++)
{
    Console.Write("введите число ");
    int n = int.Parse(Console.ReadLine());
    count += n;
    if (n > 10) count1 += 1;
    else if (n < -10) count2 += 1;
    if (n > max) max = n;
    else if (n < min) min = n;
}
double sred = (double)count / 10;
Console.WriteLine($"сумма всех чисел = {count}");
Console.WriteLine($"больше 10 = {count1}");
Console.WriteLine($"меньше -10 = {count2}");
Console.WriteLine($"среднее арифметическое всех чисел = {sred}");
Console.WriteLine($"минимальное = {min}, максимальное = {max}");