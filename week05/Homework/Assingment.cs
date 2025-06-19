class Assignment
{
    protected string _studentname;
    protected string _topic;



    public Assignment(string Name, string Topic)
    {
        _studentname = Name;
        _topic = Topic;
    }

    public string GetSummary()
    {
        return $"{_studentname} - {_topic}"; 
    }




}