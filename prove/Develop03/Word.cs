using System;

public class Word
{
    public string Text { get; }
    public bool Hidden { get; set; }
      public Word(string text)
    {
        Text = text;
        Hidden = false;
    }
    public string Display()
    {
        return Hidden ? new string('_', Text.Length) : Text;
    }
}
