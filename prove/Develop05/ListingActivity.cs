class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are your personal strengths?",
        "Who are people that you have helped this week?",
        "Who are some of your personal heroes?"
    };

    private int _count;

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by listing them.";
    }

    public override void Run()
    {
        DisplayStartingMessage();

        Random random = new Random();
        Console.WriteLine(_prompts[random.Next(_prompts.Count)]);
        ShowCountdown(5); // Give time to think.

        List<string> items = new List<string>();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("Enter an item: ");
            string item = Console.ReadLine();
            if (!string.IsNullOrEmpty(item))
            {
                items.Add(item);
            }
        }

        _count = items.Count;
        Console.WriteLine($"You listed {_count} items.");

        DisplayEndingMessage();
    }
}