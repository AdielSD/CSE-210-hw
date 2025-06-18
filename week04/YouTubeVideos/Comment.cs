public class Comment
{
    private string _commentText;
    private string _userName;

    public Comment(string commentText, string userName)
    {
        _commentText = commentText;
        _userName = userName;

    } 
    
     public string commentText
    {
        get { return _commentText; }
    }

    public string userName
    {
        get { return _userName; }
    }
}