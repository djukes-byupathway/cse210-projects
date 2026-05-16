using System.Globalization;

public class PromptGenerator
{
   
    public List<string> _prompts =
        new List<String>();
    Random randomGenerator = new Random();

    public PromptGenerator()
    {
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        _prompts.Add("Did I have a good/bad experience at a restaurant or store?");
        _prompts.Add("What success did I have today?");
        _prompts.Add("What challenges did I face, and how did I overcome them?");
    }
    public string GetRandomPrompt()
    {
        // code goes here 
        int randIndex = randomGenerator.Next(0, (_prompts.Count - 1));
        String _prompt = _prompts[randIndex];
        return _prompt;
    }

}