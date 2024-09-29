public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    // Constructor to initialize the entry
    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    // Method to display the entry
    public void Display()
    {
        Console.WriteLine(_date);
        Console.WriteLine(_promptText);
        Console.WriteLine($"{_entryText}\n");
    }
}