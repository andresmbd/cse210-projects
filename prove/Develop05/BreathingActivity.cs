class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by guiding your breathing.";
    }

    public override void Run()
    {
        DisplayStartingMessage();

        for (int i = 0; i < _duration / 6; i++) // Alternating messages for breathing in and out.
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(3);
            Console.WriteLine("Breathe out...");
            ShowCountdown(3);
        }

        DisplayEndingMessage();
    }
}
