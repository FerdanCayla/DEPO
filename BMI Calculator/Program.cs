using System.Security.Cryptography;

Console.BackgroundColor=ConsoleColor.Black;
Console.ForegroundColor=ConsoleColor.White;

Console.WriteLine("BMI Calculator, Press ENTER to continue!");

Console.ReadKey();

Console.WriteLine("Input your weight in kilograms: ");
double weight = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input your height in centimeters: ");
double height = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Your BMI is:" + weight / ((height/100)*(height/100)));

double BMI = weight / ((height/100)*(height/100));

if (BMI <= 18.5)
{
    Console.WriteLine("You are Underweight, your health risk is Mininmal");
}
else if (BMI < 24.9)
{
    Console.WriteLine("You are Normal, your health risk is Mininmal");
}
else if (BMI < 29.9)
{
{
    Console.WriteLine("You are Obese, your health risk is High");
}
else if (BMI < 39.9)
    Console.WriteLine("You are Overweight, your health risk is Increased");
}
else if (BMI < 34.9)
{
    Console.WriteLine("You are Severely Obese, your health risk is Very High");
}
else if (BMI >= 40)
{
    Console.WriteLine("You are Morbidly Obese, your health risk is Extremely High ");
}

Console.ReadKey();
