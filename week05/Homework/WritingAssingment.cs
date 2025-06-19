class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic) 
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"Student: {_studentname}, Topic: {_topic}, Title: {_title}";
    }
}
