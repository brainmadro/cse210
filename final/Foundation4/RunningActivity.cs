class RunningActivity : Activity
{
	private double _distance;

	public RunningActivity(DateTime date, int length, double distance) : base(date, length)
	{
		_distance = distance;
	}

	public override string GetSummary()
	{
		return $"{_date.ToString("dd MMM yyyy")} Running ({_length} min): {GetDistance()}, {GetSpeed()}, {GetPace()}";
	}

	public override string GetDistance()
	{
		return $"Distance {_distance} km";
	}

	public override string GetSpeed()
	{
		return $"Speed: {_distance / _length * 60} kph";
	}

	public override string GetPace()
	{
		return $"Pace: { _length / _distance} min per km";
	}
}