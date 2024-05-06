using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    private List<string> entries = new List<string>();

    public void AddEntry(string prompt, string response, string date)
    {
        entries.Add($"{date}: {prompt} - {response}");
    }

    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine(entry);
            }
        }
        Console.WriteLine("Entries saved to " + fileName);
    }

    public void LoadFromFile(string fileName)
    {


        using (StreamReader reader = File.OpenText(fileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                entries.Add(line);
            }
        }
        Console.WriteLine("loaded from " + fileName);
    }
}
