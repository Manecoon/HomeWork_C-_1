// Программа, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.

Console.WriteLine("Веедите первое число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Веедите второе число: ");
int numB = Convert.ToInt32(Console.ReadLine());
if (numA > numB)
{
    Console.WriteLine($"Наибольшее число: {numA}");
    Console.Write($"Наименьшее число: {numB}");
}
else
{
    Console.WriteLine($"Наибольшее число: {numB}");
    Console.Write($"Наименьшее число: {numA}");
}