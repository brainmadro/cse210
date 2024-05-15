/// <summary>
/// With my design I don´t really need a Scripture contructor. 
/// I tried to use Word Class but I think my design is easier
/// As you can see I create constructors but don´t really use it.
/// Additional
/// There is an option interface
/// You can add verses one by one and the programm will generate the scripture
/// You can add more than one scripture and when you go Play mode, it will select one randomly
/// The words that will be hidden will be only those that are still visible.
/// What happend if you choose to play before add any scripture?
/// What happend if you choose an option different from the list?
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        string option;
        List<Scripture> scriptures = new();
        Console.WriteLine("Welcome to Scripture Memorizer!");

        do
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.Write("1. Add Scripture\n2. Play\n3. Quit\n");
            Console.Write("What would you like to do? ");
            option = Console.ReadLine();            
            
            switch (option)
            {
                case "1":
                    string verserNumber;
                    Scripture scripture1 = new Scripture();

                    Console.WriteLine("Enter the book: ");
                    scripture1.SetBook(Console.ReadLine());
                    Console.WriteLine("Enter the chapter: ");
                    scripture1.SetChapter(int.Parse(Console.ReadLine()));
                    while (true)
                    {
                        Console.WriteLine("Enter the verse number, to quit enter (q): ");
                        verserNumber = Console.ReadLine();
                        //If you enter any other letter this will crash
                        if (verserNumber == "q")
                        {
                            break;
                        }
                        Console.WriteLine("Enter the verse text: ");
                        scripture1.SetVerse(int.Parse(verserNumber), Console.ReadLine());
                    }
                    scriptures.Add(scripture1);
                    break;
                case "2":
                    if (scriptures.Count > 0)
                    {
                        string gameOption;
                        Random rnd = new Random();
                        int randomIndex = rnd.Next(0, scriptures.Count);
                        Scripture scripture2 = scriptures[randomIndex];
                        List<Verse> tmpVerses = scripture2.GetVerses();

                        while (true)
                        {
                            Console.Clear();
                                
                                scripture2.DisplayReference();
                                scripture2.DisplayVerses();
                                Console.Write("Press enter to continue or type 'quit' to finish ");
                                gameOption = Console.ReadLine();

                                if (gameOption == "quit" || scripture2.IsCompletelyHidden())
                                {
                                    scripture2.SetVerses(tmpVerses);
                                    Environment.Exit(0);
                                }

                                scripture2.HideRandomWords();
                        }
                    }
                    else
                    {
                        Console.WriteLine("There's no scriptures yet, please add some");
                    }
                    break;
                case "3":
                    Console.WriteLine("Bye!");
                    break;
                default:
                    Console.WriteLine("Sorry the option you choose is not available");
                    break;
            }
            
        } while (option != "3");
    }
}