using System.Text.RegularExpressions;

class GoalManager
{
	private List<Goal> _goals = [];
	private int _score = 0;

	public void Start()
	{
		Console.WriteLine("\nPlease select one of the following options:");
		Console.Write("1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit\n");
		Console.Write("What would you like to do? ");
	}

	public void DisplayPlayerInfo()
	{
		Console.WriteLine();
		Console.WriteLine($"You have {_score} points");
		Console.WriteLine();
	}

	public void ListGoalNames()
	{
		for (int i = 0; i < _goals.Count; i++)
		{
			Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
		}
	}

	public void ListGoalDetails()
	{
		if (_goals.Count > 0)
		{
			for (int i = 0; i < _goals.Count; i++)
			{
				Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
			}
		}
		else
		{
			Console.WriteLine("There are no goals to show yet :(");
		}
	}

	public void CreateGoal()
	{
		Goal goal = null;
		Console.WriteLine("What type of goal is:");
		Console.Write("1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal\n");
		string choise = Console.ReadLine();
		Console.WriteLine("What is the name of your goal?");
		string goalName = Console.ReadLine();
		Console.WriteLine("What is a short description of it?");
		string goalDescription = Console.ReadLine();
		Console.WriteLine("What is the amount of points associated with this goal?");
		int goalPoints = int.Parse(Console.ReadLine());

		if (choise == "1")
		{
			goal = new SimpleGoal(goalName, goalDescription, goalPoints);
		}
		else if (choise == "2")
		{
			goal = new EternalGoal(goalName, goalDescription, goalPoints);
		}
		else if (choise == "3")
		{
			Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
			int goalTarget = int.Parse(Console.ReadLine());
			Console.WriteLine("What is the bonus for accomplish it that many times?");
			int goalBouns = int.Parse(Console.ReadLine());
			goal = new ChecklistGoal(goalName, goalDescription, goalPoints, goalTarget, goalBouns);
		} else {
			CreateGoal();
		}

		_goals.Add(goal);
	}

	public void RecordEvent()
	{
		Console.WriteLine("The goals are:");
		ListGoalNames();
		Console.Write("Which goal did you accomplish? ");
		int position = int.Parse(Console.ReadLine());
		_score += _goals[position - 1].RecordEvent();
		DisplayPlayerInfo();
		SaveGoals();
	}

	public void SaveGoals()
	{
		if (_goals.Count > 0)
		{
			try
			{	
				Console.Write("Save as: ");
				string filename = $"snapshots/{Console.ReadLine()}.txt";
				using (StreamWriter outputFile = new StreamWriter(filename))
				{
					outputFile.WriteLine(_score);
					foreach (Goal goal in _goals)
					{
						outputFile.WriteLine(goal.GetStringRepresentation());
					}
				}
			}
			catch (System.Exception e)
			{
				Console.WriteLine($"Error: {e}");
			}
		}
		else
		{
			Console.WriteLine("There are no goals to save yet :(");
		}
	}

	public void LoadGoals()
	{
		try
		{
			Console.Write("Goals filename: ");
			string filename = $"snapshots/{Console.ReadLine()}.txt";
			string[] lines = System.IO.File.ReadAllLines(filename);

			if (lines.Length > 0)
			{
				_score = int.Parse(lines[0]);

				for (int i = 1; i < lines.Length; i++)
				{
					Goal goal = null;
					string line = lines[i];
					string pattern = @"\[(.*?)\]";
					Match match = Regex.Match(line, pattern);
					string goalType = match.Success ? match.Groups[1].Value : null;
					string[] properties = Regex.Replace(line, pattern, "").Split(';');

					switch (goalType)
					{
						case "SimpleGoal":
							goal = new SimpleGoal(properties[0], properties[1], int.Parse(properties[2]));
							break;
						case "EternalGoal":
							goal = new EternalGoal(properties[0], properties[1], int.Parse(properties[2]));
							break;
						case "ChecklistGoal":
							ChecklistGoal  checklistGoal = new ChecklistGoal(properties[0], properties[1], int.Parse(properties[2]), int.Parse(properties[4]), int.Parse(properties[5]));
							checklistGoal.SetAmountCompleted(int.Parse(properties[3]));
							goal = checklistGoal;
							break;
						default:
							Console.WriteLine("Something went wrong");
							break;
					}

					_goals.Add(goal);				
				}
			}
		}
		catch (System.Exception e)
		{
			Console.WriteLine($"Error: {e}");
		}
	}
}