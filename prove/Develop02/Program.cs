using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string choice;
        string prompt;
        string response;
        string date;
        Console.WriteLine("Welcome to your journal");

        do
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Read");
            Console.WriteLine("3. Save to file");
            Console.WriteLine("4. Load from file ");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write(" enter prompt ");
                    prompt = Console.ReadLine();
                    Console.Write("Enter entry: ");
                    response = Console.ReadLine();
                    date = " 05/26/2003";
                    journal.AddEntry(prompt, response, date);
                    
                    break;
                case "2":
                    Console.WriteLine("Journal Entries:");
                    journal.DisplayEntries();
                    break;
                case "3":
                    Console.WriteLine("save to file");

                    string fileName = Console.ReadLine();
                    journal.SaveToFile(fileName);
                    break;
                case "4":
                    Console.WriteLine("load to file");
                    
                    Console.Write("Enter file name: ");
                    fileName = Console.ReadLine();
                    journal.LoadFromFile(fileName);
                    Console.WriteLine("Entries loaded from file.");
                    break;
                    break;
                case "5":
                    Console.WriteLine("exiting ");
                    break;
                default:
                    Console.WriteLine("invalid choice");
                    break;
            }

        } while (choice != "5");
    }
}