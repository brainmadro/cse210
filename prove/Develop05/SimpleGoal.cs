class SimpleGoal : Goal
{
	private bool _isComplete;

	public SimpleGoal(string name, string description, int points) : base(name, description, points)
	{
		
	}

	public override int RecordEvent()
	{
		_isComplete = true;
		Console.WriteLine($"Congratulations! You have earned {_points}!");
		return _points;
	}

    public override bool isComplete()
    {
        return _isComplete;
    }

	public override string GetStringRepresentation()
	{
		return $"[SimpleGoal]{_shortName};{_description};{_points};{isComplete()}";
	}
}