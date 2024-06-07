class OutdoorGatheringEvent : Event
{
	private string _weatherForecast;

	public OutdoorGatheringEvent(string title, string description, Address address, DateTime date, TimeSpan time, string weatherForecast) : base(title, description, address, date, time)
	{
		_weatherForecast = weatherForecast;
	}

	public override string GetFullDetails()
	{
		string details = GetStandardDetails();
		return details + $"\n\nOutdoor Gathering Event\nWeather: {_weatherForecast}";
	}

	public override string GetShortDescription()    
	{
		return $"Outdoor Gathering Event\n{_title}, {_date}";
	}
}