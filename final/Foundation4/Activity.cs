abstract class Activity
{
	protected DateTime _date;
	protected int _length;

	public Activity(DateTime date, int length)
	{
		_date = date;
		_length = length;
	}

	public abstract string GetSummary();
	public abstract string	GetDistance();
	public abstract string	GetSpeed();
	public abstract string	GetPace();
}