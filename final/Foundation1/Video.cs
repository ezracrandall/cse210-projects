class Video
{
    public string _title { get; set; }
    public string _author { get; set; }
    public int _length { get; set; }
    private List<Comment> comments = new List<Comment>();
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void comment(string userName, string userText)
    {
        Comment comment = new Comment(userName, userText);
        comments.Add(comment);
    }
    public int GetNumComments()
    {
        return comments.Count;
    }
    public void DisplayInfo()
    {
        Console.WriteLine("Title: " + _title);
        Console.WriteLine("Author: " + _author);
        Console.WriteLine("length:" + _length + " seconds");
        Console.WriteLine("Comment Count: " + GetNumComments());
        Console.WriteLine("Comments -------- >");
        foreach (Comment comment in comments)
        {
            Console.WriteLine("  - " + comment.user + ": " + comment.userText);
        }
    }
}