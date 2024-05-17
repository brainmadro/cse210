class Activity
{
	protected string _name;
	protected string _description;
	protected int _duration;

	public Activity()
	{
		
	}

	public void DisplayStartingMessage()
	{
		Console.WriteLine($"Welcome to the {_name} Activity\n");
		Console.WriteLine(_description);
		Console.WriteLine();
		Console.Write("How long, in seconds, would you like for your session? ");
		_duration = int.Parse(Console.ReadLine());
	}

	public void DisplayEndingMessage()
	{
		Console.WriteLine("Well done!!");
		ShowSpinner(1);
		Console.WriteLine();
		Console.Write($"You have completed {_duration} seconds of the {_name} Activity");
		ShowSpinner(1);
		Console.WriteLine();
	}

	public void ShowSpinner(int seconds)
	{
		DateTime startTime = DateTime.Now;
		DateTime futureTime = startTime.AddSeconds(seconds);
		DateTime currentTime;

		do
		{
			currentTime = DateTime.Now;
			Console.Write("\\");
			Thread.Sleep(333);
			Console.Write("\b \b");
			Console.Write("-");
			Thread.Sleep(333);
			Console.Write("\b \b");
			Console.Write("/");
			Thread.Sleep(333);
			Console.Write("\b \b");
		} while (currentTime < futureTime);
	}

	public void ShowCountDown(int seconds)
	{
		while (seconds > 0)
		{
			Console.Write(seconds);
			Thread.Sleep(1000);
			Console.Write("\b \b");
			seconds -= 1;
		}
	}
}