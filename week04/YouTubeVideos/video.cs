public class Video
{
    // Properties
    public string Title { get; }
    public string Author { get; }
    public int LengthInSeconds { get; }
    private List<Comment> _comments = new List<Comment>();

    // Constructor
    public Video(string title, string author, int lengthInSeconds)
    {
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSeconds;
    }

    // Method to add a comment
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Method to get number of comments
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    // Method to get all comments
    public List<Comment> GetComments()
    {
        return _comments;
    }

    // Method to display video information
    public string GetVideoInfo()
    {
        return $"Title: {Title}\nAuthor: {Author}\nLength: {LengthInSeconds} seconds\nNumber of comments: {GetNumberOfComments()}";
    }
}