using System.Text.Json;

class PromptGenerator
{
	private List<string> _prompts;

	public PromptGenerator()
	{
		string filePath = "prompts.json";
		try
        {
            string json = File.ReadAllText(filePath);
            _prompts = JsonSerializer.Deserialize<List<string>>(json);
        }
        catch (Exception ex)
        {
            Console.WriteLine("There was an error trying to read the prompts file: " + ex.Message);
        }
	}

	public string GetRandomPrompt()
	{
		Random random = new Random();
		return _prompts[random.Next(0, _prompts.Count - 1)];
	}
}