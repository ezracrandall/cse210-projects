public class ScriptureReference
{
    public string Book {get;}
    public int Chapter {get;}
    public int VerseStart {get;}
    public int VerseEnd {get;}

    public ScriptureReference(string reference)
    {
        Console.WriteLine($"scripture {reference}");

        var parts = reference.Split(':');
        Console.WriteLine($"verse length: {parts.Length}");
        Book = parts[0];

        if (parts.Length > 1)
        {
            var verseParts = parts[1].Split('-');
            Console.WriteLine($"verse parts {verseParts.Length}");

            Chapter = int.Parse(verseParts[0]);
            if (verseParts.Length >= 2)
                VerseStart = int.Parse(verseParts[1]);

            if (verseParts.Length == 3) // Check for verse end if available
                VerseEnd = int.Parse(verseParts[2]);
        }
    }

    public string Display()
    {
        return $"{Book} {Chapter}:{VerseStart}" + (VerseEnd != null ? $"-{VerseEnd}" : "");
    }
}
