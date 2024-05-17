class BreathingActivity : Activity
{
	public BreathingActivity()
	{
		_name = "Breathing";
		_description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
	}
	public void Run()
	{
		DateTime startTime = DateTime.Now;
		DateTime futureTime = startTime.AddSeconds(_duration);
		DateTime currentTime;

		Console.Clear();
		Console.WriteLine("Get ready...");
		ShowSpinner(2);

		do
		{
			Console.Write("Breathe in...");
			ShowCountDown(4);
			Console.WriteLine();
			Console.Write("Breathe out...");
			ShowCountDown(6);
			Console.WriteLine();
			currentTime = DateTime.Now;
		} while (currentTime < futureTime);
		DisplayEndingMessage();
	}
}