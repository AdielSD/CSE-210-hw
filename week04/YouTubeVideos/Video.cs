public class VideoInfo
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<string> _comments;

    // Constructor
    public VideoInfo(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
        _comments = new List<string>();


    }

    public void AddComment(string comment)
    {
        _comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public void DisplayVideoDetails()
    {
        Console.WriteLine($"Title: {_title} author: {_author} Duratiom: {_lengthInSeconds}");
        Console.WriteLine($"Number of comments: {GetNumberOfComments}");
    }
}

    

