// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hoş Geldin.");

double num1;
double num2;
double num3;

Console.WriteLine("1. Sayi:");
num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("2. Sayi:");
num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("3. Sayi:");
num3 = Convert.ToDouble(Console.ReadLine());

double result = (num1 * num2 + num3) /3;
Console.WriteLine("Sayilarin Ortalamasi: " + result);

Console.ReadKey();