using System;


internal class Program
{
    private static void Main(string[] args)
    {
        var scripture = new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

        while (!scripture.AllWordsHidden())
        {
            Console.Clear();
            scripture.Display();
            var input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;
            else
                scripture.HideRandomWord();
                

        }

        Console.WriteLine("program ended");
        Console.ReadKey();
    }
}