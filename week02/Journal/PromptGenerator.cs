public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public PromptGenerator()
    {
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        _prompts.Add("What is something I learned today?");
        _prompts.Add("How did I express kindness or gratitude today?");
        _prompts.Add("What is one moment I am grateful for today?");
        _prompts.Add("How did I take care of myself today, mentally, physically, or emotionally?");
        _prompts.Add("What is one thing you did for your calling today?");
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}