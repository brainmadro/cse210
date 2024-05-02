using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        DisplayResult(name, SquareNumber(number));
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
        //Displays the message, "Welcome to the Program!" 
    }
    static string PromptUserName()
    {
        //Asks for and returns the user's name (as a string)
        Console.Write("Please enter your name: ");
        return Console.ReadLine();

    }
    static int PromptUserNumber()
    {
        //Asks for and returns the user's favorite number (as an integer)
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }
    static int SquareNumber(int number)
    {
        //Accepts an integer as a parameter and returns that number squared (as an integer)
        return number * number;
    }
    static void DisplayResult(string name, int number)
    {
        //Accepts the user's name and the squared number and displays them.
        Console.WriteLine($"{name}, the square of your number is {number}");
    }
}