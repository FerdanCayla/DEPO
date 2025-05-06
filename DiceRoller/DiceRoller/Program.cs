Random numberGen = new Random();
int roll01=0;
int roll02=1;
int attempts=0;
Console.WriteLine("Enter the roll");

while (roll01!=roll02)
{
    Console.ReadKey();
    roll01 = numberGen.Next(1,7);
    roll02 = numberGen.Next(1,7);
    attempts++;
    Console.WriteLine("You Rolled: "+ roll01 + "-" + roll02);
}

Console.WriteLine("It took " + attempts + " tries to roll two of a kind.");

Console.ReadKey();