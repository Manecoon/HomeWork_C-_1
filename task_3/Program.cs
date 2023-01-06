// Программа принимает на вход число и выдает, яыляется ли число четным.
Console.WriteLine("Веедите число: ");
int numA = Convert.ToInt32(Console.ReadLine());
if (numA % 2 == 0) 
Console.Write($"Число {numA} является четным.");
else 
Console.Write($"Число {numA} является НЕчетным.");