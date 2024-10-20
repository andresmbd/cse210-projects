public class Assignment
{
    // Private member variables
    private string _studentName;
    private string _topic;

    // Constructor to initialize the student name and topic
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Method to get the assignment summary
    public string GetSummary()
    {
        return _studentName + " - " + _topic;
    }

    // Public method to allow derived classes to access the student's name
    public string GetStudentName()
    {
        return _studentName;
    }
}
