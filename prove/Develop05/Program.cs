using System;

/// <summary>
/// Set messages for when there are no goals yet to show or save
/// Show the goal points when list
/// Change points type to int, it's better to handle
/// Add getter for goal's name
/// Add getter for goal's goint
/// Add setter for amount Completed
/// RecordEvent now will return the points to add to score
/// Save every time you acomplish something
/// try catch fot file open and save
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        string option;
        GoalManager goalManager = new GoalManager();

        do
        {
            goalManager.Start();
            option = Console.ReadLine();            
            
            switch (option)
            {
                case "1":
                    goalManager.CreateGoal();
                    break;
                case "2":
                    goalManager.ListGoalDetails();
                    break;
                case "3":
                    goalManager.SaveGoals();
                    break;                  
                case "4":
                    goalManager.LoadGoals();
                    break;                  
                case "5":
                    goalManager.RecordEvent();
                    break;                    
                case "6":
                    Console.WriteLine("Bye!");
                    break;
                default:
                    Console.WriteLine("Sorry the option you choose is not available");
                    break;
            }
            
        } while (option != "6");
    }
}