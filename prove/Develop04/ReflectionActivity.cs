class ReflectionActivity : Activity
{
	private List<string> _prompts;
	private List<string> _questions;

	public ReflectionActivity()
	{
		_name = "Reflection";
		_description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
		_prompts = [
			"Think of a time when you stood up for someone else.",
			"Think of a time when you did something really difficult.",
			"Think of a time when you helped someone in need.",
			"Think of a time when you did something truly selfless."
		];
		_questions = [
			"Why was this experience meaningful to you?",
			"Have you ever done anything like this before?",
			"How did you get started?",
			"How did you feel when it was complete?",
			"What made this time different than other times when you were not as successful?",
			"What is your favorite thing about this experience?",
			"What could you learn from this experience that applies to other situations?",
			"What did you learn about yourself through this experience?",
			"How can you keep this experience in mind in the future?"
		];
	}

	public void Run()
	{
		Console.Clear();
		Console.WriteLine("Get ready...");
		ShowSpinner(2);
		Console.WriteLine("Consider the following prompt:");
		DisplayPrompt();
		Console.WriteLine("When you have something in mind, press enter to continue.");
		Console.ReadLine();
		Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
		Console.Write("You may begin in: ");
		ShowCountDown(5);
		Console.Clear();
		DisplayQuestions();
		DisplayEndingMessage();
	}

	private string GetRandomPrompt()
	{
		Random rnd = new Random();
		int randomIndex = rnd.Next(0, _prompts.Count);
		return _prompts[randomIndex];
	}

	private string GetRandomQuestion(List<string> questions = null)
	{
		if (questions == null)
		{
			questions = _questions;
		}

		Random rnd = new Random();
		int randomIndex = rnd.Next(0, questions.Count);
		return questions[randomIndex];
	}

	private void DisplayPrompt()
	{
		Console.WriteLine($"== {GetRandomPrompt()} ==");
	}

	private void DisplayQuestions()
	{
		List<string> questionsToShow = _questions;
		int secondsPerQuestion = (_duration / _questions.Count() < 1) ? 1 : _duration / _questions.Count();

		DateTime startTime = DateTime.Now;
		DateTime futureTime = startTime.AddSeconds(_duration);
		DateTime currentTime;

		Console.WriteLine($"You'll have {secondsPerQuestion} second(s) per question\n");

		do
		{
			string question = GetRandomQuestion(questionsToShow);
			questionsToShow.Remove(question);
			Console.Write($"{question} ");
			ShowSpinner(secondsPerQuestion);
			Console.WriteLine();
			currentTime = DateTime.Now;
		} while (currentTime < futureTime && questionsToShow.Count() > 0);
	}
}