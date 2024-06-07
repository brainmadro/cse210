abstract class Event
{
	protected string _title;
	protected string _description;
	protected Address _address;
	protected DateTime _date;
	protected TimeSpan _time;

	public Event(string title, string description, Address address, DateTime date, TimeSpan time)
	{
		_title = title;
		_description = description;
		_address = address;
		_date = date;
		_time = time;
	}
	
	public string GetStandardDetails()
	{
		return $"Event: {_title}\n{_description}\n\nDate: {_date}\nDuration: {_time}\n\n{_address.GetAddressString()}";
	}

	public abstract string GetFullDetails();

	public abstract string GetShortDescription();
}