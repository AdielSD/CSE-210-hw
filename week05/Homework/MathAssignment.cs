class MathAssignment : Assignment
{
    private string _textBookSection;
    private string _problems;

    public MathAssignment(string StudentName, string Topic, string textBookSection, string problems)
    : base(StudentName, Topic)
    {
        _textBookSection = textBookSection;
        _problems = problems;
    }

    public string GetHomeworkList ()
    {
        return $" {_textBookSection} - {_problems} "; 
    }

}