using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int guess;
        
        int magicNumber = randomGenerator.Next(1, 100);

        do
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }

        } while (guess != magicNumber);
        
        Console.WriteLine($"The magic number is: {magicNumber}");
    }
}