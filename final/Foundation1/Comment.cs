class Comment
{
    public string user { get; set; }
    public string userText { get; set; }

    public Comment(string userName, string text)
    {
        user = userName;
        userText = text;
    }
}