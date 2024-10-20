public class WritingAssignment : Assignment
{
    // Private member variable specific to WritingAssignment
    private string _title;

    // Constructor that calls the base constructor and initializes the new variable
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

    // Method to get the writing assignment information
    public string GetWritingInformation()
    {
        return _title + " by " + GetStudentName();
    }
}
