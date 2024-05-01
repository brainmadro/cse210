using System;

class Program
{
    static void Main(string[] args)
    {
        string letter;
        
        Console.Write("Please enter your grade percentage: ");
        float gradePercentage = float.Parse(Console.ReadLine());

        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations!!");
        }
        else
        {
            Console.WriteLine("You can do it better next time");
        }
    }
}