using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Hider> _words;

    // constructor: takes a reference and a scripture text, and splits it into Word objects
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Hider>();


        foreach (string word in text.Split(' '))
        {
            _words.Add(new Hider(word));
        }
    }

    public void HideRandomWord()
    {
        Random random = new Random();
        int index = random.Next(_words.Count);
        _words[index].Hide();
    }

    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText();

        foreach (Hider word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Hider word in _words)
        {
            if (word.IsHidden() == false) // word.IsHidden() is false (word is visible)
            {
                // This block will execute because the condition is true.
                return false; // return false indicating not all words are hidden.
            }
        }
        return true; // If all words are hidden, return true
    }
}