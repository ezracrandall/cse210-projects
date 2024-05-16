using System;


public class Scripture
{
    private readonly List<Word> _words;
    private readonly ScriptureReference _reference;
    public Scripture(string reference, string text)
    {
        _words = text.Split(' ').Select(w => new Word(w)).ToList();
        _reference = new ScriptureReference(reference);
    }
    public void Display()
    {
        Console.WriteLine($"Reference: {_reference.Display()}");
        foreach (var word in _words)
        {
            Console.Write(word.Display() + " ");
        }
        Console.WriteLine("\n enter to continue, quit to end the program ");
    }

    public bool HideRandomWord()
    {
        var visibleWords = _words.Where(w => !w.Hidden).ToList();
        if (visibleWords.Count == 0)
            return false;

        var random = new Random();
        var indexToHide = random.Next(visibleWords.Count);
        visibleWords[indexToHide].Hidden = true;
        return true;
    }

    public bool AllWordsHidden()
    {
        return _words.All(w => w.Hidden);
    }

}

