abstract class Goal
{
	protected string _shortName;
	protected string _description;
	protected int _points;

	public Goal(string name, string description, int points)
	{
		_shortName = name;
		_description = description;
		_points = points;
	}

	public string GetName()
	{
		return _shortName;
	}

	public int GetPoints()
	{
		return _points;
	}

	public abstract int RecordEvent();

	public abstract bool isComplete();

	public virtual string GetDetailsString()
	{
		return $"[{(isComplete() ? 'X' : ' ' )}] {_shortName} ({_description}) Get {_points} points!";
	}

	public abstract string GetStringRepresentation();
}