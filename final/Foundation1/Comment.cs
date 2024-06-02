class Comment
{
	private string _author;
	private string _text;

	public Comment(string author, string text)
	{
		_author = author;
		_text = text;
	}

	public string GetAuthor()
	{
		return _author;
	}

	public string GetText()
	{
		return _text;
	}
}