class Journal
{
    private List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void AddEntry(string prompt,string response, string date)
    {

        
        entries.Add(new Entry(prompt, response, date));
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in entries)
        {
            Console.WriteLine(entry.toString());
        }
    }
}