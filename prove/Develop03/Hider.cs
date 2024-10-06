public class Hider
{
    private string _text;
    private bool _isHidden;

    // constructor 
    public Hider(string text)
    {
        _text = text;
        _isHidden = false; // Firstly the scripture will show all the words
    }

    public void Hide() // lets hide the word
    {
        _isHidden = true;
    }

    public void Show() // For showing the word
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return "____"; // Show underscores for hidden words
        }
        else
        {
            return _text; // Show the word if it's not hidden
        }
    }
}