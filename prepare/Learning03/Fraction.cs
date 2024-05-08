class Fraction
{
	private int _bottom;
	private int _top;

	public Fraction()
	{
		_bottom = 1;
		_top = 1;
	}

	public Fraction(int wholeNumber)
	{
		_bottom = 1;
		_top = wholeNumber;
	}

	public Fraction(int top, int bottom)
	{
		_bottom = bottom;
		_top = top;
	}
	
	public int GetBottom()
	{
		return _bottom;
	}

	public int GetTop()
	{
		return _top;
	}

	public void SetBottom(int bottom)
	{
		 _bottom = bottom;
	}

	public void SetTop(int top)
	{
		_top = top;
	}

	public string GetFractionString()
	{
		return $"{_top}/{_bottom}";
	}

	public double GetDecimalValue()
	{
		return (double) _top / _bottom;
	}

}