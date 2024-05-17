class ListingActivity : Activity
{
	private int _count;
	private List<string> _prompts;

	public ListingActivity()
	{
		_name = "Listing";
		_description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area";
		_prompts = [
			"Who are people that you appreciate?",
			"What are personal strengths of yours?",
			"Who are people that you have helped this week?",
			"When have you felt the Holy Ghost this month?",
			"Who are some of your personal heroes?"
		];
	}
	public void Run()
	{
		Console.Clear();
		Console.WriteLine("Get ready...");
		ShowSpinner(2);
		Console.WriteLine("List as many responses you can to the following prompt:");
		Console.WriteLine($"== {GetRandomPrompt()} ==");
		Console.Write("You may begin in: ");
		ShowCountDown(5);
		Console.WriteLine();
		string prompt = GetRandomPrompt();
		Console.WriteLine(prompt);
		List<string> responses = GetListFromUser();
		Console.WriteLine($"You listed {responses.Count()} items!");
	}

	private string GetRandomPrompt()
	{
		Random rnd = new Random();
		int randomIndex = rnd.Next(0, _prompts.Count);
		return _prompts[randomIndex];
	}

	private List<string> GetListFromUser()
	{
		DateTime startTime = DateTime.Now;
		DateTime futureTime = startTime.AddSeconds(_duration);
		DateTime currentTime;
		List<string> responses = [];

		do
		{	
			responses.Add(Console.ReadLine());
			currentTime = DateTime.Now;
		} while (currentTime < futureTime);

		return responses;
	}
}