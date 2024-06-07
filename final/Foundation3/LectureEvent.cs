class LectureEvent : Event
{
	private string _speaker;
	private int _capacity;

	public LectureEvent(string title, string description, Address address, DateTime date, TimeSpan time, string speaker, int capacity) : base(title, description, address, date, time)
	{
		_speaker = speaker;
		_capacity = capacity;
	}

	public override string GetFullDetails()
	{
		string details = GetStandardDetails();
		return details + $"\n\nLecture Event\nSpeaker Name: {_speaker}\nCapacity: {_capacity}";
	}

	public override string GetShortDescription()    
	{
		return $"Lecture Event\n{_title}, {_date}";
	}
}