// Программа на вход принимает число (N), а на выходе показывает все четные числа от 1 до N.
Console.WriteLine("Веедите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int index = 1;
Console.Write($"Все четные числа до числа {N}:");
while (index <= N)
{
    if (index % 2 == 0)
    {
        Console.Write($" {index}");
        index++;
    }
    index++;
}