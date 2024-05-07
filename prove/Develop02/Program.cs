using System;


/// <summary>
/// This program has an external file with 30 questions to prompt
/// randomly, also every journal created can be save in a `jrl` file, 
/// there is not need to write the extension for saving and reading
/// the journal files.
/// This jrl files and the prompt list have JSON structure.
/// </summary>
{
    static void Main(string[] args)
    {
        string option;
        PromptGenerator promptGenerator = new PromptGenerator();
        Journal journal = new Journal();
        Console.WriteLine("Welcome th the Journal Program!");

        do
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.Write("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\n");
            Console.Write("What would you like to do? ");
            option = Console.ReadLine();            
            
            switch (option)
            {
                case "1":
                    Entry entry = new();
                    DateTime theCurrentTime = DateTime.Now;
                    string prompt = promptGenerator.GetRandomPrompt();
                    string dateText = theCurrentTime.ToShortDateString();

                    Console.WriteLine(prompt);
                    
                    entry._date = dateText;
                    entry._promptText = prompt;
                    entry._entryText = Console.ReadLine();

                    journal.AddEntry(entry);
                    break;
                case "2":
                    journal.DisplayAll();
                    break;
                case "3":
                    Console.WriteLine("What is the filename?");
                    journal.LoadFromFile(Console.ReadLine());
                    break;
                case "4":
                    Console.WriteLine("What is the filename?");
                    journal.SaveToFile(Console.ReadLine());
                    break;
                case "5":
                    Console.WriteLine("Bye!");
                    break;
                default:
                    Console.WriteLine("Sorry the option you choose is not available");
                    break;
            }
            
        } while (option != "5");
    }
}