class SwimmingActivity : Activity
{
	private int _laps;

	public SwimmingActivity(DateTime date, int length, int laps) : base(date, length)
	{
		_laps = laps;
	}

	public override string GetSummary()
	{
		return $"{_date.ToString("dd MMM yyyy")} Swimming ({_length} min): {GetDistance()}, {GetSpeed()}, {GetPace()}";
	}

	public override string GetDistance()
    {
      return $"Distance {_laps * 50 / 1000} km";
    }

		public override string GetSpeed()
    {
        return $"Speed: {60 / (_length / (_laps * 50 / 1000))} kph";
    }

		public override string GetPace()
    {
        return $"Pace: {_length / (_laps * 50 / 1000)} min per km";
    }
}