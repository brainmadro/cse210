class ReceptionEvent : Event
{
	private string _rsvpEmail;

	public ReceptionEvent(string title, string description, Address address, DateTime date, TimeSpan time, string rsvpEmail) : base(title, description, address, date, time)
	{
		_rsvpEmail = rsvpEmail;
	}

	public override string GetFullDetails()
	{
		string details = GetStandardDetails();
		return details + $"\n\nReception Event\nEmail for RSVP: {_rsvpEmail}";
	}

	public override string GetShortDescription()    
	{
		return $"Reception Event\n{_title}, {_date}";
	}
}