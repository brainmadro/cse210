using System.Text.Json;

class Journal
{
	List<Entry> _entries = new List<Entry>();

	public void AddEntry(Entry newEntry)
	{
		_entries.Add(newEntry);
	}

	public void DisplayAll()
	{
		foreach (Entry entry in _entries)
		{
			entry.Display();
		}
	}

	public void SaveToFile(string file)
	{
		string filename = $"{file}.jrl";
		try
		{
            using StreamWriter outputFile = new StreamWriter(filename);
			var json = JsonSerializer.Serialize(_entries);
			outputFile.WriteLine(json);
        }
		catch (Exception ex)
        {
            Console.WriteLine("There was an error trying to save the journal: " + ex.Message);
        }
	}

	public void LoadFromFile(string file)
	{
		string filename = $"{file}.jrl";
		try
        {
            string json = File.ReadAllText(filename);
            _entries = JsonSerializer.Deserialize<List<Entry>>(json);
        }
        catch (Exception ex)
        {
            Console.WriteLine("There was an error trying to read the journal file: " + ex.Message);
        }
	}
}