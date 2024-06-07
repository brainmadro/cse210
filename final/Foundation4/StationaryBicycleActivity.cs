class StationaryBicycleActivity : Activity
{
	private double _speed;

	public StationaryBicycleActivity(DateTime date, int length, double speed) : base(date, length)
	{
		_speed = speed;
	}

	public override string GetSummary()
	{
		return $"{_date.ToString("dd MMM yyyy")} StationaryBicycle ({_length} min): {GetDistance()}, {GetSpeed()}, {GetPace()}";
	}

	public override string GetDistance()
	{
		return $"Distance {60 / _speed * _length} km";
	}

	public override string GetSpeed()
	{
		return $"Speed: {_speed} kph";
	}

	public override string GetPace()
	{
		return $"Pace: {60 / _speed} min per km";
	}
}