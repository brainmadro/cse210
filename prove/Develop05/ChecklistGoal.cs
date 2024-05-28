class ChecklistGoal : Goal
{
	private int _amountCompleted;
	private int _bonus;
	private int _target;

	public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
	{
		_bonus = bonus;
		_target = target;
		_amountCompleted = 0;
	}

	public void SetAmountCompleted(int amountCompleted)
	{
		_amountCompleted = amountCompleted;
	}
	

	public override int RecordEvent()
	{
		_amountCompleted += 1;

		Console.WriteLine($"Congratulations! You have earned {_points}!");

		if (_target == _amountCompleted)
		{
			Console.WriteLine($"And {_bonus} extra points!");
			return _points + _bonus;
		}
		else
		{
			Console.WriteLine($"Don't forget! You need to complete {_target - _amountCompleted} more to earn {_bonus} extra points");
		}

		return _points;
	}

    public override bool isComplete()
    {
        return _target == _amountCompleted;
    }

	public override string GetDetailsString()
	{
		string detailsString = $"[{(isComplete() ? 'X' : ' ' )}] {_shortName} ({_description})";
		return detailsString += $" -- Currently completed: {_amountCompleted}/{_target}  Get {_points} points + bonus!";
	}

	public override string GetStringRepresentation()
	{
		return $"[ChecklistGoal]{_shortName};{_description};{_points};{_amountCompleted};{_target};{_bonus}";
	}
}