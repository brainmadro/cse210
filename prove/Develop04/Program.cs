using System;

/// <summary>
/// In the Reflection Activity this program will show
/// as many question as can, until time is fulfill,
/// so it will divide at least one second per question
/// And the questions will not be repeated
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        string option;

        do
        {
            Console.WriteLine("\nPlease select one of the following options:");
            Console.Write("1. Start breathing activity\n2. Start reflecting activity\n3. Start listing activity\n4. Quit\n");
            Console.Write("What would you like to do? ");
            option = Console.ReadLine();            
            
            switch (option)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.DisplayStartingMessage();
                    breathingActivity.Run();
                    break;
                case "2":
                    ReflectionActivity reflectionActivity = new ReflectionActivity();
                    reflectionActivity.DisplayStartingMessage();
                    reflectionActivity.Run();
                    break;
                case "3":
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.DisplayStartingMessage();
                    listingActivity.Run();
                    break;                    
                case "4":
                    Console.WriteLine("Bye!");
                    break;
                default:
                    Console.WriteLine("Sorry the option you choose is not available");
                    break;
            }
            
        } while (option != "4");
    }
}