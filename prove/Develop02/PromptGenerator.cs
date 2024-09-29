using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "What happened today?",
        "What did I do today that I am proud of?",
        "What was the most interesting thing I saw or heard today?",
        "What was the worst thing that happened today?",
        "What was the best thing that happened today?"

    };

    // Method to get a random prompt
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}