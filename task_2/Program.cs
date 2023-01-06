// Программа приниает на вход три числа и выдает максимальное из этих чисел.
Console.WriteLine("Веедите первое число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Веедите второе число: ");
int numB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Веедите третье число: ");
int numC = Convert.ToInt32(Console.ReadLine());
int max = numA;
if (numA > max) max = numA;
if (numB > max) max = numB;
if (numC > max) max = numC;
Console.Write("Максимальное число: ");
Console.Write(max);