public class Comment
{
    // Properties
    public string CommenterName { get; }
    public string Text { get; }

    // Constructor
    public Comment(string commenterName, string text)
    {
        CommenterName = commenterName;
        Text = text;
    }

    // Method to display comment information
    public string GetCommentInfo()
    {
        return $"{CommenterName}: {Text}";
    }
}